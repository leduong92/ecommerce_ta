using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Application.Dtos
{
    public class AddToCartRequestDto
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public string CustomerRegionCode { get; set; } = string.Empty;
    }
    public class UpdateCartRequest : AddToCartRequestDto { }
}
