using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Domain.Entities
{
    public class ProductVariantOptionValue
    {
        public int ProductVariantId { get; set; }
        public int ProductOptionValueId { get; set; }
        public ProductVariant ProductVariant { get; set; }
        public ProductOptionValue ProductOptionValue { get; set; }
    }
}
