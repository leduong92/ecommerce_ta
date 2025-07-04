using eCommerce.Domain.Entities;
using eCommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.Application.Services
{
    public class WarehouseService
    {
        private readonly AppDbContext _context;

        public WarehouseService(AppDbContext context)
        {
            _context = context;
        }

        // Make sure your Warehouse model has Latitude and Longitude properties
        // And your DbContext is configured for spatial data if you want to use true geography calculations.
        // For simple calculations, Haversine formula is used, which doesn't require spatial extensions.

        /// <summary>
        /// Finds the nearest warehouse to a given customer location within a specific region.
        /// </summary>
        /// <param name="customerLatitude">Customer's latitude.</param>
        /// <param name="customerLongitude">Customer's longitude.</param>
        /// <param name="regionId">The ID of the region to filter warehouses.</param>
        /// <returns>The nearest Warehouse, or null if none found in the region.</returns>
        public async Task<Warehouse?> GetNearestWarehouseAsync(double customerLatitude, double customerLongitude, int regionId)
        {
            // Simple Haversine distance calculation (approximate, not true geodesic)
            // For production, consider using database's spatial functions (e.g., SqlServer.Distance)
            // or a dedicated geospatial library.

            var warehouses = await _context.Warehouses
                                .Where(w => w.RegionId == regionId)
                                .ToListAsync();

            if (!warehouses.Any())
            {
                return null;
            }

            Warehouse? nearestWarehouse = null;
            double minDistance = double.MaxValue;

            foreach (var warehouse in warehouses)
            {
                double distance = CalculateHaversineDistance(customerLatitude, customerLongitude, warehouse.Latitude, warehouse.Longitude);
                if (distance < minDistance)
                {
                    minDistance = distance;
                    nearestWarehouse = warehouse;
                }
            }

            return nearestWarehouse;
        }

        // Haversine formula to calculate distance between two lat/lon points in kilometers
        private double CalculateHaversineDistance(double lat1, double lon1, double lat2, double lon2)
        {
            const double R = 6371; // Radius of Earth in kilometers

            var dLat = ToRadians(lat2 - lat1);
            var dLon = ToRadians(lon2 - lon1);

            var a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                    Math.Cos(ToRadians(lat1)) * Math.Cos(ToRadians(lat2)) *
                    Math.Sin(dLon / 2) * Math.Sin(dLon / 2);

            var c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

            return R * c;
        }

        private double ToRadians(double angle)
        {
            return Math.PI * angle / 180.0;
        }
    }
}
