using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Domain.Entities
{
    public enum DeliveryType
    {
        StandardCurbside, // Giao hàng tại lề đường/cổng
        ThresholdDelivery, // Giao hàng đến ngưỡng cửa/tầng 1
        RoomOfChoice,      // Giao hàng vào phòng mong muốn
        WhiteGlove         // Giao hàng, lắp đặt, dọn dẹp bao bì
    }

    public class ShippingServiceLevel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;// e.g., "Standard Shipping", "Expedited Shipping", "Prime 2-Day"
        public string Description { get; set; } = string.Empty;
        public int EstimatedDeliveryDaysMin { get; set; }
        public int EstimatedDeliveryDaysMax { get; set; }
        public DeliveryType DeliveryType { get; set; } // New: Loại dịch vụ giao hàng
        public bool IncludesAssembly { get; set; } = false; // New: Có bao gồm lắp đặt không
        public bool RequiresSpecialHandling { get; set; } = false; // New: Yêu cầu xử lý đặc biệt (VD: cần nhiều người khiêng)
        public ICollection<ShippingRateRule>? ShippingRateRules { get; set; }
    }
}
