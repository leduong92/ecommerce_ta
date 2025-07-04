using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Application.Dtos
{
    public class ProductDto
    {
        public long Id { get; set; }
        public string? Sku { get; set; }
        public string Slug { get; set; }
        public string? Name { get; set; }
        public decimal OriginalPrice { set; get; }
        public decimal BasePrice { get; set; }
        public string? Description { get; set; }
        public string? MetaKeyword { get; set; }
        public string? MetaDescription { get; set; }
        public string? DefaultImageUrl { get; set; }
        public decimal? Depth { get; set; } = 0;
        public decimal? Width { get; set; } = 0;
        public decimal? Height { get; set; } = 0;
        public decimal? NetWeightKg { get; set; } = 0;
        public decimal? GrossWeightKg { get; set; } = 0;
        public decimal? NetWeightLbs { get; set; } = 0;
        public decimal? GrossWeightLbs { get; set; } = 0;
        public int? MaxHeight { get; set; } = 0;
        public int QuantityMultiplier { get; set; } = 1;
        public double? CBM { get; set; } = 0;

    }
}
