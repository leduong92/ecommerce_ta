using eCommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Application.Dtos
{
    public class GlobalShippingLaneDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; // e.g., "Vietnam-US West Coast (Ocean)"
        public int OriginShippingZoneId { get; set; }
        public ShippingZoneDto OriginShippingZone { get; set; } = null!;
        public int DestinationShippingZoneId { get; set; }
        public ShippingZoneDto DestinationShippingZone { get; set; } = null!;
        public string PrimaryCarrierPartner { get; set; } = null!; // e.g., "Maersk", "Evergreen", "Schenker"
        public string TransitMode { get; set; } = string.Empty; // "Ocean", "Air Cargo", "Road", "Rail"
        public int EstimatedTransitDaysMin { get; set; }
        public int EstimatedTransitDaysMax { get; set; }
        public bool SupportsConsolidation { get; set; } = true; // Có hỗ trợ gom hàng không
    }
}
