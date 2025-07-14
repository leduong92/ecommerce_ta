using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Domain.Entities
{
    public class ProductVariantCombinationImage
    {
        public int Id { get; set; }
        public int ProductVariantId { get; set; }
        public int? FabricId { get; set; }
        public int? FinishId { get; set; }
        public int? ProductOptionValueId { get; set; } // size
        public string ImageUrl { get; set; } = string.Empty;
        public bool IsPrimary { get; set; }

        public ProductVariant? ProductVariant { get; set; }
    }
}
