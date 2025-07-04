using eCommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Application.Dtos
{
    public class ShippingRouteLeg
    {
        public ShippingRateRule AppliedRule { get; set; } = null!; // The rule used for this leg
        public decimal LegCost { get; set; }
        public int LegEstimatedDaysMin { get; set; }
        public int LegEstimatedDaysMax { get; set; }
        public string LegDescription { get; set; } = string.Empty;
    }
}
