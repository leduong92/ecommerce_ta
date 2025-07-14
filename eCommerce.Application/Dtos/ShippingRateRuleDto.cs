using eCommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Application.Dtos
{
    public class ShippingRateRuleDto
    {
        public int Id { get; set; }
        public string RuleName { get; set; } = string.Empty; // e.g., "US Standard Shipping for Books"
        public string? Description { get; set; }
        // Mối quan hệ với Origin & Destination Zones
        public int OriginShippingZoneId { get; set; }
        public ShippingZoneDto OriginShippingZone { get; set; } = null!;

        public int DestinationShippingZoneId { get; set; }
        public ShippingZoneDto DestinationShippingZone { get; set; } = null!;
        // Mức độ dịch vụ
        public int ShippingServiceLevelId { get; set; }
        public ShippingServiceLevelDto ShippingServiceLevel { get; set; } = null!;
        // New: Reference ProductShippingProfile for granular control
        public int? ProductShippingProfileId { get; set; } // New: Reference product characteristics
        public ProductShippingProfileDto? ProductShippingProfile { get; set; }
        // Tùy chọn cho loại sản phẩm (nếu áp dụng cho một danh mục cụ thể)
        public int? ProductCategoryId { get; set; }
        public ProductCategory? ProductCategory { get; set; }
        // New: Reference GlobalShippingLane for international freight
        public int? GlobalShippingLaneId { get; set; }
        public GlobalShippingLaneDto? GlobalShippingLane { get; set; }

        // Core Rate calculation
        public decimal BaseRate { get; set; } // Phí cố định
        // Dựa trên trọng lượng/kích thước/thể tích
        public decimal RatePerKg { get; set; } = 0; // Phí thêm cho mỗi kg (hoặc kg thể tích)
        public decimal RatePerCbm { get; set; } = 0; // Phí thêm cho mỗi mét khối (cubic meter)
        public decimal RatePerItem { get; set; } = 0; // Phí thêm cho mỗi món hàng

        // Weight/Volume/Item Count Tiers for Rule Applicability
        public decimal MinApplicableWeightKg { get; set; } = 0; // Minimum weight for this rule to apply
        public decimal MaxApplicableWeightKg { get; set; } = 0; // Maximum weight for this rule to apply (0 for no max)
        public decimal MinApplicableCbm { get; set; } = 0; // Minimum CBM for this rule
        public decimal MaxApplicableCbm { get; set; } = 0; // Maximum CBM for this rule (0 for no max)
        public int MinItemsInOrder { get; set; } = 0;
        public int MaxItemsInOrder { get; set; } = 0; // 0 for no max
        public decimal MaxWeightKg { get; set; } = 0; // 0 for no max, useful for tiers
        public decimal MinWeightKg { get; set; } = 0; // 0 for no min

        // Dựa trên giá trị đơn hàng (Order Value) Order Value Thresholds
        public decimal MinOrderValue { get; set; } = 0;
        public decimal MaxOrderValue { get; set; } = 0; // 0 for no max
        public bool IsFreeShippingThreshold { get; set; } = false; // Đánh dấu đây là quy tắc miễn phí vận chuyển
        public decimal FreeShippingMinOrderValue { get; set; } = 0; // Ngưỡng miễn phí vận chuyển

        // Surcharges / Conditions specific to furniture/global shipping
        public decimal FlatSurcharge { get; set; } = 0; // Any flat surcharge
        public decimal PercentageSurcharge { get; set; } = 0; // Percentage of base cost
        public string? SurchargeReason { get; set; } // e.g., "Remote Area", "Hazardous Material", "Customs Clearance"

        // New: Surcharge for specific delivery conditions (e.g., apartment floors)
        public bool ApplyFloorSurcharge { get; set; } = false;
        public int MinFloorForSurcharge { get; set; } = 0; // E.g., apply from 2nd floor up
        public decimal SurchargePerFloor { get; set; } = 0;

        // Weight/Volume Thresholds for Rule Applicability (can be used with tiers)
        public decimal MinOrderWeightOrVolume { get; set; } = 0; // Use the greater of actual weight or dimensional weight/volume
        public decimal MaxOrderWeightOrVolume { get; set; } = 0; // 0 for no max

        public bool IsRuralAreaSurcharge { get; set; } = false;
        public decimal RuralAreaSurchargeAmount { get; set; } = 0;

        // Navigation to ShippingRateTier if using more granular weight/volume tiers
        public List<ShippingRateTierDto>? ShippingRateTiers { get; set; }
    }
}
