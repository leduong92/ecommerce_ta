namespace eCommerce.Domain.Entities
{
    public class ProductImage : BaseEntity
    {
        public int Id { get; set; }
        public int ProductVariantId { get; set; }
        public ProductVariant ProductVariant { get; set; } = null!;
        public string? ImageUrl { get; set; }
        public bool IsPrimary { get; set; }
        public int SortOrder { get; set; }
    }
}
