using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Application.Dtos
{
    public class FabricDto
    {
        public int Id { get; set; }
        public string Fabric { get; set; } = default!;
        public bool IsCustom { get; set; }
        public string? ImageUrl { get; set; }
        public decimal? CustomPrice { get; set; }
        public bool IsSelected { get; set; }
        public List<ProductImageDto> Images { get; set; } = new();
    }

}
