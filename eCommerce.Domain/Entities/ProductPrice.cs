namespace eCommerce.Domain.Entities
{
    public class ProductPrice : BaseEntity
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;
        public int RegionId { get; set; }
        public Region Region { get; set; } = null!;
        public decimal Price { get; set; } //Giá sản phẩm theo khu vực
        public string? Currency { get; set; } // ISO 4217 (e.g., VND, USD) // The currency for this price (e.g., USD, VND)
        public DateTime EffectiveDate { get; set; } = DateTime.UtcNow; // When this price becomes active
        public DateTime? ExpirationDate { get; set; } // When this price expires (optional)
    }
}
