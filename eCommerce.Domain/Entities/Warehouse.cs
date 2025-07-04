namespace eCommerce.Domain.Entities
{
    public class Warehouse : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string StateProvince { get; set; } = string.Empty;
        public string ZipCode { get; set; } = string.Empty;
        public string CountryCode { get; set; } = string.Empty; // ISO 3166-1 alpha-2 (e.g., US, VN)
        public string? ContactPhone { get; set; }
        public string? Email { get; set; }

        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string? Description { get; set; }

        // Navigation property for inventory held at this warehouse
        public ICollection<InventoryItem>? InventoryItems { get; set; }

        // Optional: Reference to a ShippingZone if a warehouse is always in a specific zone
        public int? ShippingZoneId { get; set; }
        public ShippingZone? ShippingZone { get; set; }
        public int? RegionId { get; set; }
        public Region? Region { get; set; }
    }
}
