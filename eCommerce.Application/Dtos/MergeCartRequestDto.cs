using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Application.Dtos
{
    public class MergeCartRequestDto
    {
        public Guid UserId { get; set; }
        public string AnonymousId { get; set; } = null!;
    }
}
