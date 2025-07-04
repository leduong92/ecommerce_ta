using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Domain.Entities
{
    public class ShippingZone
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; // e.g., "Contiguous US", "Europe Zone 1", "Vietnam Northern"
        public string Description { get; set; } = string.Empty;

        // Foreign Key to Region
        public int? RegionId { get; set; }
        public Region? Region { get; set; } // Optional, a zone can be larger than a single region or cross regions

        // Navigation properties for zone details (e.g., states, zip codes)
        public ICollection<ShippingZoneDetail>? ShippingZoneDetails { get; set; }

        // Navigation properties for rate rules referencing this zone
        public ICollection<ShippingRateRule>? OriginRateRules { get; set; }
        public ICollection<ShippingRateRule>? DestinationRateRules { get; set; }
    }
}
