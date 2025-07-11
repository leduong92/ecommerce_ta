using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Application.Dtos
{
    public class FinishDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string Code { get; set; } = default!;
        public string? ImageUrl { get; set; }
        public bool IsSelected { get; set; }
        public List<ProductImageDto> Images { get; set; } = new();
    }
}
