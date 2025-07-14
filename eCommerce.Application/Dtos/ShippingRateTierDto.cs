using eCommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Application.Dtos
{
    public class ShippingRateTierDto
    {
        public int Id { get; set; }
        public int ShippingRateRuleId { get; set; }
        public decimal MinValue { get; set; } // Start of tier (e.g., 0kg, 10kg, 50kg)
        public decimal MaxValue { get; set; } // End of tier (e.g., 9.99kg, 49.99kg)
        public string TierUnit { get; set; } = string.Empty; // "Kg", "Cbm", "Item"
        public decimal RatePerUnit { get; set; } // Rate per kg or per cbm within this tier
        public decimal FixedTierCost { get; set; } // Fixed cost for entering this tier
    }
}
