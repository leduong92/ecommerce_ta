namespace eCommerce.Domain.Entities
{
    public class Cart 
    {
        public int Id { get; set; }
        public string? SessionId { get; set; } // For anonymous users
        public Guid? UserId { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdatedDate { get; set; }

        public ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();
    }

}
