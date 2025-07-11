using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Domain.Entities
{
    public class ProductVariantFinish
    {
        public int ProductVariantId { get; set; }
        public ProductVariant ProductVariant { get; set; } = default!;

        public int FinishId { get; set; }
        public Finish Finish { get; set; } = default!;

        // Optional: sau này có thể thêm PriceAdjustment riêng cho Finish
        public decimal? PriceAdjustment { get; set; }

        public ICollection<ProductVariantFinishImage> Images { get; set; } = new List<ProductVariantFinishImage>();
    }
}
