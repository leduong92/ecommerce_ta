using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Application.Dtos
{
    public class CartItemDto
    {
        public int Id { get; set; }
        public int CartId { get; set; }
        public int ProductId { get; set; }
        public int? SizeId { get; set; }
        public int? FabricId { get; set; }
        public int? FinishId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public string Sku { get; set; } = string.Empty;
        public string RegionCode { get; set; } = "";
        public int ProductVariantId { get; set; }
        public string VariantSummary { get; set; }
        public int Quantity { get; set; }
        public string ImageUrl { get; set; }
        public string Currency { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
