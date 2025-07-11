using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Domain.Entities
{
    public class Finish : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string Code { get; set; } = default!;
        public string? ImageUrl { get; set; }

        public ICollection<ProductVariantFinish> ProductVariantFinishes { get; set; } = new List<ProductVariantFinish>();
    }
}
