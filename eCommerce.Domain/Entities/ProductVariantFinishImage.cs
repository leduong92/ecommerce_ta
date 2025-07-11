using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Domain.Entities
{
    public class ProductVariantFinishImage : BaseEntity
    {
        public int Id { get; set; }
        public int ProductVariantId { get; set; }
        public int FinishId { get; set; }

        public string ImageUrl { get; set; } = default!;
        public bool IsPrimary { get; set; }

        public ProductVariantFinish ProductVariantFinish { get; set; } = default!;
    }
}
