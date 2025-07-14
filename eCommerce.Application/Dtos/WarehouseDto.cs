using eCommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Application.Dtos
{
    public class WarehouseDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Address1 { get; set; } = string.Empty;
        public string Address2 { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string StateProvince { get; set; } = string.Empty;
        public string ZipCode { get; set; } = string.Empty;
        public string CountryCode { get; set; } = string.Empty; // ISO 3166-1 alpha-2 (e.g., US, VN)
        public string? ContactPhone { get; set; }
        public string? Email { get; set; }

        public bool IsPrimaryWarehouseForRegion { get; set; }

        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string? Description { get; set; }

        // Navigation property for inventory held at this warehouse
        public List<InventoryItemDto>? InventoryItems { get; set; }

        // Optional: Reference to a ShippingZone if a warehouse is always in a specific zone
        public int? ShippingZoneId { get; set; }
        public ShippingZoneDto ShippingZone { get; set; }
        public int? RegionId { get; set; }
    }
}
