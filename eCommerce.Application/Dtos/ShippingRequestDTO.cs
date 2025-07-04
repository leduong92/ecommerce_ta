using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Application.Dtos
{
    public class ShippingRequestDTO
    {
        public int RegionId { get; set; }
        public List<ShippingItemDTO> Items { get; set; }

    }
}
