using eCommerce.Domain.Entities;

namespace eCommerce.Application.Dtos
{
    public class OrderItemDetailsDto
    {
        public int ProductId { get; set; } // Only need ProductId here
        public int Quantity { get; set; }
    }
}
