using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Application.Dtos
{
    public class ShippingRequestDto
    {
        public int RegionId { get; set; }
        public List<ShippingItemDto> Items { get; set; }

    }
}
