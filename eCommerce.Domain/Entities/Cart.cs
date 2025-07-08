namespace eCommerce.Domain.Entities
{
    public class Cart : BaseEntity
    {
        public int Id { get; set; }
        public Guid? UserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdatedDate { get; set; }

        public ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();
    }

}
