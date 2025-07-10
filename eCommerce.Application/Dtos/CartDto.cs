using eCommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Application.Dtos
{
    public class CartDto
    {
        public int Id { get; set; }
        public Guid? UserId { get; set; }
        public string? AnonymousId { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime LastModifiedDate { get; set; } = DateTime.UtcNow;
        public decimal Total => CartItems.Sum(x => x.UnitPrice * x.Quantity);
        public ICollection<CartItemDto> CartItems { get; set; } = new List<CartItemDto>();
    }
}
