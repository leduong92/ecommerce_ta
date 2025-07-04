using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Domain.Entities
{
    public class ProductRegionAvailability
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;

        public int RegionId { get; set; }
        public Region Region { get; set; } = null!;

        public bool IsAvailable { get; set; } // Chỉ định rõ ràng sản phẩm có sẵn ở region này
        public DateTime AvailableFrom { get; set; }
        public DateTime? AvailableTo { get; set; }
    }
}
