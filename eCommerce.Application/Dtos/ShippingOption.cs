using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Application.Dtos
{
    public class ShippingOption
    {
        public string ServiceLevel { get; set; } = string.Empty;
        public string DeliveryType { get; set; } = string.Empty;
        public bool IncludesAssembly { get; set; }
        public int EstimatedDeliveryDaysMin { get; set; }
        public int EstimatedDeliveryDaysMax { get; set; }
        public decimal Cost { get; set; }
        public string? Description { get; set; }
    }
}
