using eCommerce.Application.Interfaces;
using eCommerce.Application.Dtos;
using eCommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using eCommerce.Domain.Entities;

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

        public async Task<ProductDetailDto?> GetProductDetailsAsync(int productId, string regionCode, double? customerLatitude, double? customerLongitude)
        {
            var region = await _context.Regions.FirstOrDefaultAsync(r => r.Code == regionCode);
            if (region == null)
            {
                throw new ArgumentException($"Region with code '{regionCode}' not found.");
            }

            // Start building the query for a single product
            IQueryable<Product> productQuery = _context.Products
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
                return null;
            }

            // Note: inventory retrieval is already handled by the .Include above.
            // Just need to access the loaded data.
            var inventory = product.InventoryItems?.FirstOrDefault();


            var price = product.Prices?.FirstOrDefault()?.Price;
            var currency = product.Prices?.FirstOrDefault()?.Currency;

            return new ProductDetailDto
            {
                Id = product.Id,
                Name = product.Name,
                Description = "High-quality modern furniture piece.",
                Category = product.ProductCategory.Name,
                Price = price,
                Currency = currency,
                WeightKg = product.NetWeightKg,
                LengthCm = product.Depth,
                WidthCm = product.Width,
                HeightCm = product.Height,
                EstimatedAvailableStock = inventory?.AvailableQuantity,
                FulfillingWarehouseName = nearestWarehouse?.Name,
                FulfillingWarehouseAddress = nearestWarehouse != null ? $"{nearestWarehouse.Address1}, {nearestWarehouse.City}" : null
            };
        }

        public async Task<IEnumerable<ProductListDto>> GetProductsByRegionAsync(string regionCode, double? customerLatitude, double? customerLongitude)
        {
            var region = await _context.Regions.FirstOrDefaultAsync(r => r.Code == regionCode);
            if (region == null)
            {
                throw new ArgumentException($"Region with code '{regionCode}' not found.");
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
                    Price = price,
                    Currency = currency,
                    EstimatedAvailableStock = inventory?.AvailableQuantity, // Null if no warehouse or no inventory item
                    WeightKg = p.NetWeightKg,
                    LengthCm = p.Depth,
                    WidthCm = p.Width,
                    HeightCm = p.Height
                };
            }).ToList();

            return productList;
        }
    }
}
