using System.ComponentModel.DataAnnotations;

namespace eCommerce.Domain.Entities
{
    public class Region 
    {
        public int Id { get; set; }
        public string? Code { get; set; } // ISO 3166-1 alpha-2 (e.g., VN, US)
        public string? Name { get; set; }
        public string? Currency { get; set; }
        public string? Description { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        // Navigation property for zones within this region
        public ICollection<ShippingZone>? ShippingZones { get; set; }
        public ICollection<Warehouse> Warehouses { get; set; }
    }
}
