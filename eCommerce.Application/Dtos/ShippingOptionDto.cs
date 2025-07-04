using eCommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Application.Dtos
{
    public class ShippingOptionDto
    {
        public string ServiceLevelName { get; set; } = string.Empty;
        public string DeliveryType { get; set; } = string.Empty;
        public bool IncludesAssembly { get; set; }
        public int EstimatedDeliveryDaysMin { get; set; }
        public int EstimatedDeliveryDaysMax { get; set; }
        public decimal TotalCost { get; set; }
        public string Currency { get; set; } = "USD";
        public string? Description { get; set; }

        public OriginWarehouseDto OriginWarehouse { get; set; } = null!;
        public string RouteDescription { get; set; } = string.Empty;
        public List<OrderItemDetailsDto> OrderItems { get; set; } = new List<OrderItemDetailsDto>();
    }
    // Đảm bảo OriginWarehouseDto cũng có các thuộc tính cần thiết
    public class OriginWarehouseDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        // Thêm các thuộc tính khác nếu cần hiển thị, ví dụ: Address, City
    }
}
