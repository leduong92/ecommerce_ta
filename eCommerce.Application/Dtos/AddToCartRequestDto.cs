using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Application.Dtos
{
    public class AddToCartRequestDto
    {
        public string? AnonymousId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public string CustomerRegionCode { get; set; } = string.Empty;
        // Add FulfillingWarehouseId to the request
        public int? FulfillingWarehouseId { get; set; } // ID của kho mà sản phẩm này được chọn từ đó
    }
    public class UpdateCartRequest : AddToCartRequestDto { }
}
