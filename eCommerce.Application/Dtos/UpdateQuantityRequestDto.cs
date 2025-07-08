using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Application.Dtos
{
    public class UpdateQuantityRequestDto
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
