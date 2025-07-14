using eCommerce.Application.Interfaces;
using eCommerce.Application.Dtos;
using eCommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using eCommerce.Domain.Entities;
using eCommerce.Shared.Common;
using System.Text.Json;

namespace eCommerce.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly AppDbContext _context;
        private readonly WarehouseService _warehouseService;

        public ProductService(AppDbContext context
            , WarehouseService warehouseService
            )
        {
            _context = context;
            _warehouseService = warehouseService;
        }

        public async Task<ApiResponse<List<InventoryItemDto>>> GetAvailableWarehousesAsync()
        {
            // Lấy danh sách các kho hàng duy nhất từ bảng InventoryItems
            var warehouses = await _context.InventoryItems
                .Select(ii => new InventoryItemDto
                {
                    WarehouseId = ii.WarehouseId,
                })
                .Distinct()
                .ToListAsync();

            return ApiResponse<List<InventoryItemDto>>.Success(warehouses);
        }

        public async Task<ApiResponse<ProductDetailDto>?> GetProductDetailsAsync(
            int productId, 
            string regionCode, 
            double? customerLatitude, 
            double? customerLongitude, 
            int? sizeId = null, 
            int? fabricId = null,
            int? finishId = null)
        {
            var region = await _context.Regions.FirstOrDefaultAsync(r => r.Code == regionCode);
            if (region == null)
            {
                return ApiResponse<ProductDetailDto>.Failure($"Region with code '{regionCode}' not found.");
            }

            // Start building the query for a single product
            IQueryable<Product> productQuery = _context.Products
                    .Include(p => p.Variants)
                        .ThenInclude(v => v.VariantOptionValues)
                            .ThenInclude(vov => vov.ProductOptionValue)
                                .ThenInclude(pov => pov.Option)
                    .Include(p => p.Variants).ThenInclude(v => v.Images)
                    .Include(p => p.Variants).ThenInclude(v => v.ProductVariantFabrics).ThenInclude(f => f.Fabric)
                    .Include(p => p.Variants).ThenInclude(v => v.ProductVariantFabrics).ThenInclude(f => f.Images)
                    .Include(p => p.Variants).ThenInclude(v => v.ProductVariantFinishes).ThenInclude(f => f.Finish)
                    .Include(p => p.Variants).ThenInclude(v => v.ProductVariantFinishes).ThenInclude(f => f.Images)
                    .Include(p => p.Variants).ThenInclude(v => v.ProductVariantCombinationImages)
                    .Include(p => p.ProductCategory)
                    .Include(p => p.Prices!.Where(pp =>
                        pp.RegionId == region.Id &&
                        pp.EffectiveDate <= DateTime.UtcNow &&
                        (pp.ExpirationDate == null || pp.ExpirationDate >= DateTime.UtcNow)))
                    .Include(p => p.RegionAvailabilities!.Where(ra => ra.RegionId == region.Id));

            Warehouse? nearestWarehouse = null;
            if (customerLatitude.HasValue && customerLongitude.HasValue)
            {
                nearestWarehouse = await _warehouseService.GetNearestWarehouseAsync(customerLatitude.Value, customerLongitude.Value, region.Id);
            }
            if (nearestWarehouse == null)
            {
                nearestWarehouse = await _context.Warehouses.FirstOrDefaultAsync(w => w.RegionId == region.Id && w.IsPrimaryWarehouseForRegion);
            }
            if (nearestWarehouse != null)
            {
                productQuery = productQuery.Include(p => p.InventoryItems!.Where(ii => ii.WarehouseId == nearestWarehouse.Id));
            }

            var product = await productQuery.FirstOrDefaultAsync(p => p.Id == productId);
            if (product == null || !product.RegionAvailabilities!.Any())
            {
                return ApiResponse<ProductDetailDto>.Failure($"Product {productId} not found."); ;
            }

            // Note: inventory retrieval is already handled by the .Include above.
            // Just need to access the loaded data.
            var inventory = product.InventoryItems?.FirstOrDefault();
            var price = product.Prices?.FirstOrDefault()?.Price;
            var currency = product.Prices?.FirstOrDefault()?.Currency;

            var selectedVariant = product.Variants.FirstOrDefault(v =>
                (!sizeId.HasValue || v.VariantOptionValues.Any(x => x.ProductOptionValueId == sizeId)) &&
                (!fabricId.HasValue || v.ProductVariantFabrics.Any(f => f.FabricId == fabricId)) &&
                (!finishId.HasValue || v.ProductVariantFinishes.Any(f => f.FinishId == finishId))
            ) ?? product.Variants.FirstOrDefault();

            if (selectedVariant == null)
                return ApiResponse<ProductDetailDto>.Failure("No variant found.");

            int? selectedSizeId = sizeId ?? selectedVariant.VariantOptionValues
                .FirstOrDefault(x => x.ProductOptionValue.Option.Name == "Size")?.ProductOptionValueId;

            var selectedFabric = selectedVariant.ProductVariantFabrics?
                .FirstOrDefault(f => f.FabricId == fabricId)
                ?? selectedVariant.ProductVariantFabrics?.FirstOrDefault();

            var selectedFinish = selectedVariant.ProductVariantFinishes?
                .FirstOrDefault(f => f.FinishId == finishId)
                ?? selectedVariant.ProductVariantFinishes?.FirstOrDefault();

            var customFabricPrice = selectedFabric?.Fabric.IsCustom == true
                ? selectedFabric.Fabric.CustomPrice ?? 0
                : 0;

            var selectedCombinationImage = selectedVariant.ProductVariantCombinationImages?
                .FirstOrDefault(img =>
                    (!sizeId.HasValue || img.ProductOptionValueId == sizeId) &&
                    (!fabricId.HasValue || img.FabricId == fabricId) &&
                    (!finishId.HasValue || img.FinishId == finishId)
                );

            var finishImage = selectedFinish?.Images?.FirstOrDefault(i => i.IsPrimary);
            var fabricImage = selectedFabric?.Images?.FirstOrDefault(i => i.IsPrimary);
            var variantImage = selectedVariant.Images?.FirstOrDefault(i => i.IsPrimary);
            var productDefaultImage = product.DefaultImageUrl;

            string imageUrl =
                selectedCombinationImage?.ImageUrl ??
                finishImage?.ImageUrl ??
                fabricImage?.ImageUrl ??
                variantImage?.ImageUrl ??
                productDefaultImage;

            var allImages = new List<ProductImageDto>();

            if (selectedCombinationImage != null)
            {
                allImages.Add(new ProductImageDto
                {
                    Id = selectedCombinationImage.Id,
                    ImageUrl = selectedCombinationImage.ImageUrl,
                    IsPrimary = true,
                    ProductVariantId = selectedVariant.Id
                });
            }
            else if (selectedFinish?.Images?.Any() == true)
            {
                allImages = selectedFinish.Images.Select(img => new ProductImageDto
                {
                    Id = img.Id,
                    ImageUrl = img.ImageUrl,
                    IsPrimary = img.IsPrimary,
                    ProductVariantId = img.ProductVariantId
                }).ToList();
            }
            else if (selectedFabric?.Images?.Any() == true)
            {
                allImages = selectedFabric.Images.Select(img => new ProductImageDto
                {
                    Id = img.Id,
                    ImageUrl = img.ImageUrl,
                    IsPrimary = img.IsPrimary,
                    ProductVariantId = img.ProductVariantId
                }).ToList();
            }
            else if (selectedVariant.Images?.Any() == true)
            {
                allImages = selectedVariant.Images.Select(img => new ProductImageDto
                {
                    Id = img.Id,
                    ImageUrl = img.ImageUrl,
                    IsPrimary = img.IsPrimary,
                    ProductVariantId = img.ProductVariantId
                }).ToList();
            }
            else if (!string.IsNullOrEmpty(productDefaultImage))
            {
                allImages.Add(new ProductImageDto
                {
                    Id = 0,
                    ImageUrl = productDefaultImage,
                    IsPrimary = true,
                    ProductVariantId = selectedVariant.Id
                });
            }

            var filteredVariantIdsBySize = product.Variants
                .Where(v => v.VariantOptionValues.Any(x => x.ProductOptionValueId == selectedSizeId))
                .Select(v => v.Id)
                .ToList();

            var variantOptionValues = product.Variants
                .SelectMany(v => v.VariantOptionValues
                    .Select(vov => new { VariantId = v.Id, vov.ProductOptionValue }))
                .ToList();

            var optionGroups = variantOptionValues
                .GroupBy(x => x.ProductOptionValue.Option.Name)
                .ToDictionary(
                    g => g.Key,
                    g => g.GroupBy(x => x.ProductOptionValue.Id).Select(g2 =>
                    {
                        var ov = g2.First().ProductOptionValue;
                        var ovVariantIds = g2.Select(x => x.VariantId).Distinct().ToList();

                        bool isAvailable = ov.Option.Name != "Size" || ovVariantIds.Intersect(filteredVariantIdsBySize).Any();

                        return new OptionDto
                        {
                            ValueId = ov.Id,
                            Value = ov.Value,
                            VariantIds = ovVariantIds,
                            IsSelected = selectedSizeId.HasValue && ov.Id == selectedSizeId.Value,
                            IsAvailable = isAvailable
                        };
                    }).ToList()
                );

            var fabricOptions = selectedVariant?.ProductVariantFabrics?.Select(f => new FabricDto
            {
                Id = f.FabricId,
                Fabric = f.Fabric.Fabric,
                IsCustom = f.Fabric.IsCustom,
                CustomPrice = f.Fabric.CustomPrice,
                IsSelected = f.FabricId == selectedFabric?.FabricId,
                ImageUrl = f.Images?.FirstOrDefault(x => x.IsPrimary)?.ImageUrl ?? "",
                Images = f.Images.Select(img => new ProductImageDto
                {
                    Id = img.Id,
                    ImageUrl = img.ImageUrl,
                    IsPrimary = img.IsPrimary,
                    ProductVariantId = img.ProductVariantId
                }).ToList()
            }).ToList();

            var finishOptions = selectedVariant?.ProductVariantFinishes?.Select(f => new FinishDto
            {
                Id = f.FinishId,
                Name = f.Finish.Name,
                IsSelected = f.FinishId == selectedFinish?.FinishId,
                ImageUrl = f.Images?.FirstOrDefault(x => x.IsPrimary)?.ImageUrl ?? "",
                Images = f.Images.Select(img => new ProductImageDto
                {
                    Id = img.Id,
                    ImageUrl = img.ImageUrl,
                    IsPrimary = img.IsPrimary,
                    ProductVariantId = img.ProductVariantId
                }).ToList()
            }).ToList();

            var result = new ProductDetailDto
            {
                Id = product.Id,
                Name = product.Name,
                Description = "High-quality modern furniture piece.",
                Category = product.ProductCategory.Name,
                Sku = product.Sku,
                DefaultImageUrl = product.DefaultImageUrl,
                Price = price,
                Currency = currency,
                WeightKg = product.NetWeightKg,
                LengthCm = product.Depth,
                WidthCm = product.Width,
                HeightCm = product.Height,
                EstimatedAvailableStock = inventory?.AvailableQuantity,
                FulfillingWarehouseName = nearestWarehouse?.Name,
                FulfillingWarehouseAddress = nearestWarehouse != null ? $"{nearestWarehouse.Address1}, {nearestWarehouse.City}" : null,
                SelectedVariant = new VariantDto
                {
                    Id = selectedVariant.Id,
                    Sku = selectedVariant.Sku,
                    PriceAdjustment = (decimal)(price + customFabricPrice),
                    ImageUrl = imageUrl,
                    Images = allImages
                },
                SizeOptions = optionGroups.ContainsKey("Size") ? optionGroups["Size"] : new List<OptionDto>(),
                FabricOptions = fabricOptions ?? new List<FabricDto>(),
                FinishOptions = finishOptions ?? new List<FinishDto>()
            };

            return ApiResponse<ProductDetailDto>.Success(result);
        }

        public async Task<ApiResponse<IEnumerable<ProductListDto>>> GetProductsByRegionAsync(string regionCode, double? customerLatitude, double? customerLongitude)
        {
            var region = await _context.Regions.Where(r => r.Code == regionCode).FirstOrDefaultAsync();
            if (region == null)
            {
                return ApiResponse<IEnumerable<ProductListDto>>.Failure($"Region with code '{regionCode}' not found.");
            }
            // Find the nearest warehouse for this region/customer location to get relevant inventory.
            // This is crucial for displaying stock quantity.
            Warehouse? nearestWarehouse = null;
            if (customerLatitude.HasValue && customerLongitude.HasValue)
            {
                nearestWarehouse = await _warehouseService.GetNearestWarehouseAsync(customerLatitude.Value, customerLongitude.Value, region.Id);
            }

            // Fallback: If no lat/long, or no nearest warehouse found, try to find a primary warehouse for the region
            if (nearestWarehouse == null)
            {
                nearestWarehouse = await _context.Warehouses
                                        .FirstOrDefaultAsync(w => w.RegionId == region.Id && w.IsPrimaryWarehouseForRegion);
            }
            // If still null, we might not be able to show accurate stock. Handle gracefully.

            IQueryable<Product> productsQuery = _context.Products
                            .Where(p => p.RegionAvailabilities!.Any(ra => ra.RegionId == region.Id))
                            .Include(p => p.Prices!.Where(pp => pp.RegionId == region.Id && pp.EffectiveDate <= DateTime.UtcNow && (pp.ExpirationDate == null || pp.ExpirationDate >= DateTime.UtcNow)))
                            .Include(p => p.ProductCategory); // This sets the base type of the IIncludableQueryable

            // Conditionally include InventoryItems based on nearestWarehouse
            if (nearestWarehouse != null)
            {
                // CORRECTED LINE: Chain the Include.
                // This adds another Include to the existing productsQuery without changing its base type for the next Include.
                productsQuery = productsQuery
                       .Include(p => p.InventoryItems!
                           .Where(ii => ii.WarehouseId == nearestWarehouse.Id));
            }

            var products = await productsQuery.ToListAsync();

            var productList = products.Select(p =>
            {
                // Get the most relevant price for the region
                var price = p.Prices?.FirstOrDefault()?.Price; // Assumes only one active price per product/region due to uniqueness constraint
                var currency = p.Prices?.FirstOrDefault()?.Currency;

                // Get inventory for the nearest warehouse
                var inventory = p.InventoryItems?.FirstOrDefault(); // Should only be one for the specified warehouse

                return new ProductListDto
                {
                    Id = p.Id,
                    Name = p.Name,
                    Category = p.ProductCategory.Name,
                    Sku = p.Sku,
                    Price = price,
                    Currency = currency,
                    EstimatedAvailableStock = inventory?.AvailableQuantity, // Null if no warehouse or no inventory item
                    WeightKg = p.NetWeightKg,
                    LengthCm = p.Depth,
                    WidthCm = p.Width,
                    HeightCm = p.Height,
                    DefaultImageUrl = p.DefaultImageUrl
                };
            }).ToList();

            return ApiResponse<IEnumerable<ProductListDto>>.Success(productList);
        }
        public async Task<ApiResponse<VariantDto>> GetVariantAsync(int productId, int? sizeId, int? fabricId, int? finishId)
        {
            var product = await _context.Products
                .Include(p => p.Variants)
                    .ThenInclude(v => v.VariantOptionValues)
                .Include(p => p.Variants)
                    .ThenInclude(v => v.Images)
                .Include(p => p.Variants)
                    .ThenInclude(v => v.ProductVariantFabrics)
                        .ThenInclude(f => f.Fabric)
                .Include(p => p.Variants)
                    .ThenInclude(v => v.ProductVariantFabrics)
                        .ThenInclude(f => f.Images)
                .Include(p => p.Variants)
                    .ThenInclude(v => v.ProductVariantFinishes)
                        .ThenInclude(f => f.Finish)
                .Include(p => p.Variants)
                    .ThenInclude(v => v.ProductVariantFinishes)
                        .ThenInclude(f => f.Images)
                .Include(p => p.Variants)
                    .ThenInclude(v => v.ProductVariantCombinationImages)
                .FirstOrDefaultAsync(p => p.Id == productId);

            if (product == null)
                return ApiResponse<VariantDto>.Failure("Product not found.");

            // STEP 1: Tìm variant chính xác nhất theo các ID truyền vào
            var selectedVariant = product.Variants.FirstOrDefault(v =>
                (!sizeId.HasValue || v.VariantOptionValues.Any(x => x.ProductOptionValueId == sizeId)) &&
                (!fabricId.HasValue || v.ProductVariantFabrics.Any(f => f.FabricId == fabricId)) &&
                (!finishId.HasValue || v.ProductVariantFinishes.Any(f => f.FinishId == finishId))
            ) ?? product.Variants.FirstOrDefault();

            // Fallback nếu không có
            if (selectedVariant == null)
            {
                selectedVariant = product.Variants.FirstOrDefault();
                if (selectedVariant == null)
                    return ApiResponse<VariantDto>.Failure("No variant found.");
            }

            // STEP 2: Lấy Fabric và Finish theo ID hoặc mặc định đầu tiên
            var selectedFabric = selectedVariant.ProductVariantFabrics?
                .FirstOrDefault(f => f.FabricId == fabricId)
                ?? selectedVariant.ProductVariantFabrics?.FirstOrDefault();

            var selectedFinish = selectedVariant.ProductVariantFinishes?
                .FirstOrDefault(f => f.FinishId == finishId)
                ?? selectedVariant.ProductVariantFinishes?.FirstOrDefault();

            // STEP 3: Tính tổng CustomPrice nếu có
            var customFabricPrice = selectedFabric?.Fabric.IsCustom == true
                ? selectedFabric.Fabric.CustomPrice ?? 0
                : 0;

            // STEP 4: Lấy ảnh theo thứ tự ưu tiên: Fabric > Finish > Variant > Product default
            // STEP 4A: Tìm ảnh theo tổ hợp nếu có
            var selectedCombinationImage = selectedVariant.ProductVariantCombinationImages?
                .FirstOrDefault(img =>
                    (!sizeId.HasValue || img.ProductOptionValueId == sizeId) &&
                    (!fabricId.HasValue || img.FabricId == fabricId) &&
                    (!finishId.HasValue || img.FinishId == finishId)
                );

            // STEP 4B: Tìm ảnh theo Finish, Fabric, Variant, Product
            var finishImage = selectedFinish?.Images?.FirstOrDefault(i => i.IsPrimary);
            var fabricImage = selectedFabric?.Images?.FirstOrDefault(i => i.IsPrimary);
            var variantImage = selectedVariant.Images?.FirstOrDefault(i => i.IsPrimary);
            var productDefaultImage = product.DefaultImageUrl;

            // STEP 4C: Chọn ảnh chính theo ưu tiên
            string imageUrl =
                selectedCombinationImage?.ImageUrl ??
                finishImage?.ImageUrl ??
                fabricImage?.ImageUrl ??
                variantImage?.ImageUrl ??
                productDefaultImage;

            // STEP 5: Tập hợp gallery ảnh theo cùng logic ưu tiên
            var allImages = new List<ProductImageDto>();

            if (selectedCombinationImage != null)
            {
                allImages.Add(new ProductImageDto
                {
                    Id = selectedCombinationImage.Id,
                    ImageUrl = selectedCombinationImage.ImageUrl,
                    IsPrimary = true,
                    ProductVariantId = selectedVariant.Id
                });
            }
            else if (selectedFinish?.Images?.Any() == true)
            {
                allImages = selectedFinish.Images.Select(img => new ProductImageDto
                {
                    Id = img.Id,
                    ImageUrl = img.ImageUrl,
                    IsPrimary = img.IsPrimary,
                    ProductVariantId = img.ProductVariantId
                }).ToList();
            }
            else if (selectedFabric?.Images?.Any() == true)
            {
                allImages = selectedFabric.Images.Select(img => new ProductImageDto
                {
                    Id = img.Id,
                    ImageUrl = img.ImageUrl,
                    IsPrimary = img.IsPrimary,
                    ProductVariantId = img.ProductVariantId
                }).ToList();
            }
            else if (selectedVariant.Images?.Any() == true)
            {
                allImages = selectedVariant.Images.Select(img => new ProductImageDto
                {
                    Id = img.Id,
                    ImageUrl = img.ImageUrl,
                    IsPrimary = img.IsPrimary,
                    ProductVariantId = img.ProductVariantId
                }).ToList();
            }
            else if (!string.IsNullOrEmpty(productDefaultImage))
            {
                allImages.Add(new ProductImageDto
                {
                    Id = 0,
                    ImageUrl = productDefaultImage,
                    IsPrimary = true,
                    ProductVariantId = selectedVariant.Id
                });
            }

            // STEP 6: Kết quả
            var result = new VariantDto
            {
                Id = selectedVariant.Id,
                Sku = selectedVariant.Sku,
                PriceAdjustment = selectedVariant.PriceAdjustment + customFabricPrice,
                ImageUrl = imageUrl,
                Images = allImages
            };

            return ApiResponse<VariantDto>.Success(result);
        }

    }
}
