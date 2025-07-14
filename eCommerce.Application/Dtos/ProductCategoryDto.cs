using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Application.Dtos
{
    public class ProductCategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        // New: Indicators for furniture specifics
        public bool IsBulky { get; set; } = false; // Cồng kềnh
        public bool RequiresAssembly { get; set; } = false; // Yêu cầu lắp đặt
        public bool IsFragile { get; set; } = false; // Dễ vỡ
        public double DefaultDimensionalFactor { get; set; } = 5000; // Factor for calculating dimensional weight (e.g., 5000 or 6000 for cm3/kg)
    }
}
