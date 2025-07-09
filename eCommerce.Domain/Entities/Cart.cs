namespace eCommerce.Domain.Entities
{
    public class Cart : BaseEntity
    {
        public int Id { get; set; }
        public Guid? UserId { get; set; }
        public string? AnonymousId { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime LastModifiedDate { get; set; } = DateTime.UtcNow;
        // Add a property to store the fulfilling warehouse ID for the entire cart
        public int? FulfillingWarehouseId { get; set; } // Nullable if cart is empty, or if not yet determined
        public ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();
    }

}
