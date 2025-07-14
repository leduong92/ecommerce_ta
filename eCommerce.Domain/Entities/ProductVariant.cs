namespace eCommerce.Domain.Entities
{
    public class ProductVariant : BaseEntity
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;
        public string Sku { get; set; } = string.Empty;
        public decimal PriceAdjustment  { get; set; }
        public ICollection<ProductImage> Images { get; set; }
        public ICollection<ProductVariantOptionValue> VariantOptionValues { get; set; }
        public ICollection<ProductVariantFabric> ProductVariantFabrics { get; set; } = new List<ProductVariantFabric>();
        public ICollection<ProductVariantFinish> ProductVariantFinishes { get; set; } = new List<ProductVariantFinish>();
        public ICollection<ProductVariantCombinationImage> ProductVariantCombinationImages { get; set; } = new List<ProductVariantCombinationImage>();
        
    }
}
