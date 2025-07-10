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

        public async Task<ApiResponse<ProductDetailDto>?> GetProductDetailsAsync(int productId, string regionCode, double? customerLatitude, double? customerLongitude, int? colorId = null, int? sizeId = null)
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
                        .ThenInclude(p => p.ProductOptionValue)
                            .ThenInclude(v => v.Option)
                .Include(p => p.Variants)
                    .ThenInclude(v => v.Images)
                .Include(p => p.ProductCategory)
                .Include(p => p.Prices!.Where(pp => pp.RegionId == region.Id && pp.EffectiveDate <= DateTime.UtcNow && (pp.ExpirationDate == null || pp.ExpirationDate >= DateTime.UtcNow)))
                .Include(p => p.RegionAvailabilities!.Where(ra => ra.RegionId == region.Id));

            Warehouse? nearestWarehouse = null;
            if (customerLatitude.HasValue && customerLongitude.HasValue)
            {
                nearestWarehouse = await _warehouseService.GetNearestWarehouseAsync(customerLatitude.Value, customerLongitude.Value, region.Id);
            }
            if (nearestWarehouse == null)
            {
                nearestWarehouse = await _context.Warehouses
                                       .FirstOrDefaultAsync(w => w.RegionId == region.Id && w.IsPrimaryWarehouseForRegion);
            }

            // Conditionally include InventoryItems for the specific product detail
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

            // Step 1: CHỌN SELECTED VARIANT ĐÚNG CẢ COLOR + SIZE
            var selectedVariant = product.Variants
                .FirstOrDefault(v =>
                    (!colorId.HasValue || v.VariantOptionValues.Any(x => x.ProductOptionValueId == colorId)) &&
                    (!sizeId.HasValue || v.VariantOptionValues.Any(x => x.ProductOptionValueId == sizeId)));

            // 2. Nếu không có, fallback chỉ theo color
            if (selectedVariant == null && colorId.HasValue)
            {
                selectedVariant = product.Variants.FirstOrDefault(v =>
                    v.VariantOptionValues.Any(x => x.ProductOptionValueId == colorId));
            }

            if (selectedVariant == null && colorId.HasValue)
            {
                selectedVariant = product.Variants.FirstOrDefault(v =>
                    v.VariantOptionValues.Any(x => x.ProductOptionValueId == colorId));
            }
            // 3. Nếu vẫn không có, fallback chỉ theo size
            if (selectedVariant == null && sizeId.HasValue)
            {
                selectedVariant = product.Variants.FirstOrDefault(v =>
                    v.VariantOptionValues.Any(x => x.ProductOptionValueId == sizeId));
            }

            selectedVariant ??= product.Variants.FirstOrDefault();

            // Step 2: Tìm colorId / sizeId mặc định từ selectedVariant nếu không có truyền lên
            var defaultColorId = selectedVariant?.VariantOptionValues
                .FirstOrDefault(x => x.ProductOptionValue.Option.Name == "Color")?.ProductOptionValueId;

            var defaultSizeId = selectedVariant?.VariantOptionValues
                .FirstOrDefault(x => x.ProductOptionValue.Option.Name == "Size")?.ProductOptionValueId;

            // Step 3: Danh sách các variant matching theo color / size
            var filteredVariantIdsByColor = product.Variants
                .Where(v => v.VariantOptionValues.Any(x => x.ProductOptionValueId == (colorId ?? defaultColorId)))
                .Select(v => v.Id)
                .ToList();

            var filteredVariantIdsBySize = product.Variants
                .Where(v => v.VariantOptionValues.Any(x => x.ProductOptionValueId == (sizeId ?? defaultSizeId)))
                .Select(v => v.Id)
                .ToList();

            // Step 4: Group theo Option (Color/Size)
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

                        bool isAvailable = true;

                        if (ov.Option.Name == "Size")
                        {
                            isAvailable = ovVariantIds.Intersect(filteredVariantIdsByColor).Any();
                        }
                        else if (ov.Option.Name == "Color")
                        {
                            isAvailable = ovVariantIds.Intersect(filteredVariantIdsBySize).Any();
                        }

                        return new OptionDto
                        {
                            ValueId = ov.Id,
                            Value = ov.Value,
                            VariantIds = ovVariantIds,
                            IsSelected = selectedVariant?.VariantOptionValues.Any(vov => vov.ProductOptionValueId == ov.Id) ?? false,
                            IsAvailable = isAvailable
                        };
                    }).ToList()
                );

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
                SelectedVariant = selectedVariant != null ? new VariantDto
                {
                    Id = selectedVariant.Id,
                    Sku = selectedVariant.Sku,
                    PriceAdjustment = selectedVariant.PriceAdjustment,
                    Images = selectedVariant.Images.Select(x => new ProductImage
                    { 
                        Id = x.Id,
                        ImageUrl = x.ImageUrl,
                        SortOrder = x.SortOrder,
                        IsPrimary = x.IsPrimary,
                        ProductVariantId = x.ProductVariantId
                    }).ToList()
                } : null,
                ColorOptions = optionGroups.ContainsKey("Color") ? optionGroups["Color"] : new List<OptionDto>(),
                SizeOptions = optionGroups.ContainsKey("Size") ? optionGroups["Size"] : new List<OptionDto>()
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
        public async Task<ApiResponse<VariantDto>> GetVariantAsync(int productId, int? colorId, int? sizeId)
        {
            var product = await _context.Products
                .Include(p => p.Variants)
                    .ThenInclude(v => v.VariantOptionValues)
                .Include(p => p.Variants)
                    .ThenInclude(v => v.Images)
                .FirstOrDefaultAsync(p => p.Id == productId);

            if (product == null) return ApiResponse<VariantDto>.Failure("Product not found.");

            var selectedVariant = product.Variants
                .FirstOrDefault(v =>
                    (!colorId.HasValue || v.VariantOptionValues.Any(x => x.ProductOptionValueId == colorId)) &&
                    (!sizeId.HasValue || v.VariantOptionValues.Any(x => x.ProductOptionValueId == sizeId)));

            if (selectedVariant == null) return null;

            var result = new VariantDto
            {
                Id = selectedVariant.Id,
                Sku = selectedVariant.Sku,
                PriceAdjustment = selectedVariant.PriceAdjustment,
                Images = selectedVariant.Images.Select(i => new ProductImage
                {
                    Id = i.Id,
                    ImageUrl = i.ImageUrl,
                    SortOrder = i.SortOrder,
                    IsPrimary = i.IsPrimary,
                    ProductVariantId = i.ProductVariantId
                }).ToList()
            };

            return ApiResponse<VariantDto>.Success(result);
        }
    }
}
