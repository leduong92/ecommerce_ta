namespace eCommerce.Domain.Entities
{
    public class OrderItem : BaseEntity
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; } // Price at the time of order placement
        public decimal TotalPrice { get; set; } // Quantity * UnitPrice
    }
}
