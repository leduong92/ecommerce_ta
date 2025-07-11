using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Domain.Entities
{
    public class ProductVariantFabric
    {
        public int ProductVariantId { get; set; }
        public ProductVariant ProductVariant { get; set; } = default!;

        public int FabricId { get; set; }
        public UPHFabric Fabric { get; set; } = default!;
        public ICollection<ProductVariantFabricImage> Images { get; set; } = new List<ProductVariantFabricImage>();
    }
}
