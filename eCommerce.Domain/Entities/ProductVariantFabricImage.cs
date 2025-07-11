using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Domain.Entities
{
    public class ProductVariantFabricImage : BaseEntity
    {
        public int Id { get; set; }
        public int ProductVariantId { get; set; }
        public int FabricId { get; set; }

        public string ImageUrl { get; set; } = default!;
        public bool IsPrimary { get; set; }

        public ProductVariantFabric ProductVariantFabric { get; set; } = default!;
    }
}
