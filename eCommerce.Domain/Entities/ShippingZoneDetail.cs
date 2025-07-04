using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Domain.Entities
{
    public enum ZoneDetailType
    {
        ZipCodePrefix, // e.g., "90210", "HN" for Hanoi (if using custom prefixes)
        StateProvince, // e.g., "CA", "NY", "Hanoi", "Ho Chi Minh"
        Country        // e.g., "US", "VN" (useful if a Zone is just a single country)
    }
    public class ShippingZoneDetail
    {
        public int Id { get; set; }
        public int ShippingZoneId { get; set; }
        public ShippingZone ShippingZone { get; set; } = null!;

        public ZoneDetailType DetailType { get; set; }
        public string Value { get; set; } = string.Empty; // e.g., "90210-90219", "CA", "VN"
        public string? Description { get; set; } // e.g., "California State", "Hanoi Postcode Prefix"
    }
}
