using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Application.Dtos
{
    public class ProductListDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public decimal? Price { get; set; }
        public string? Currency { get; set; }
        public decimal WeightKg { get; set; }
        public decimal LengthCm { get; set; }
        public decimal WidthCm { get; set; }
        public decimal HeightCm { get; set; }
        public int? EstimatedAvailableStock { get; set; } // Quantity available in the nearest warehouse
    }
    public class ProductDetailDto : ProductListDto
    {
        public string? Description { get; set; }
        public string? FulfillingWarehouseName { get; set; }
        public string? FulfillingWarehouseAddress { get; set; }
    }
}
