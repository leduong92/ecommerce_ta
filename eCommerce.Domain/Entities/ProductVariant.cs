namespace eCommerce.Domain.Entities
{
    public class ProductVariant
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;
        public string Sku { get; set; } = string.Empty;
        public decimal PriceAdjustment  { get; set; }
        public bool IsActive { get; set; }
        public ICollection<ProductImage> ProductImages { get; set; }
        public ICollection<ProductVariantOptionValue> ProductVariantOptionValues { get; set; }

    }
}
