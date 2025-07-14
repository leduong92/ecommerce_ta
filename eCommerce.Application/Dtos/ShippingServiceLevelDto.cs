using eCommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Application.Dtos
{
    public class ShippingServiceLevelDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;// e.g., "Standard Shipping", "Expedited Shipping", "Prime 2-Day"
        public string Description { get; set; } = string.Empty;
        public int EstimatedDeliveryDaysMin { get; set; }
        public int EstimatedDeliveryDaysMax { get; set; }
        public DeliveryType DeliveryType { get; set; } // New: Loại dịch vụ giao hàng
        public bool IncludesAssembly { get; set; } = false; // New: Có bao gồm lắp đặt không
        public bool RequiresSpecialHandling { get; set; } = false; // New: Yêu cầu xử lý đặc biệt (VD: cần nhiều người khiêng)
    }
}
