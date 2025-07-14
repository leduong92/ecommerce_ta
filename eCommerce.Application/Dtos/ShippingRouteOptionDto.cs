using eCommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Application.Dtos
{
    public class ShippingRouteOptionDto
    {
        public WarehouseDto OriginWarehouse { get; set; } = null!;
        public string ServiceLevelName { get; set; } = string.Empty;
        public string DeliveryType { get; set; } = string.Empty;
        public bool IncludesAssembly { get; set; }
        public int EstimatedDeliveryDaysMin { get; set; }
        public int EstimatedDeliveryDaysMax { get; set; }
        public decimal TotalCost { get; set; }
        public string RouteDescription { get; set; } = string.Empty;

        public List<ShippingRouteLegDto> RouteLegs { get; set; } = new List<ShippingRouteLegDto>();
    }

    public class ShippingRouteLegDto
    {
        public ShippingRateRuleDto AppliedRule { get; set; }
        public string LegDescription { get; set; } = string.Empty;
        public decimal LegCost { get; set; }
        public int LegEstimatedDaysMin { get; set; }
        public int LegEstimatedDaysMax { get; set; }
    }
}
