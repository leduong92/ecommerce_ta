using eCommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Application.Dtos
{
    public class ShippingRouteOption
    {
        public Warehouse OriginWarehouse { get; set; } = null!;
        public string ServiceLevelName { get; set; } = string.Empty;
        public string DeliveryType { get; set; } = string.Empty;
        public bool IncludesAssembly { get; set; }
        public int EstimatedDeliveryDaysMin { get; set; }
        public int EstimatedDeliveryDaysMax { get; set; }
        public decimal TotalCost { get; set; }
        public string RouteDescription { get; set; } = string.Empty;

        public List<ShippingRouteLeg> RouteLegs { get; set; } = new List<ShippingRouteLeg>();
    }
}
