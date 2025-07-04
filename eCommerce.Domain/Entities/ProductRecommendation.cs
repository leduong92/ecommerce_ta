using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Domain.Entities
{
    public class ProductRecommendation: BaseEntity
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int RecommendedProductId { get; set; }
        public string? RecommendationType { get; set; } //CategoryBased, PurchaseHistoryBased
    }
}
