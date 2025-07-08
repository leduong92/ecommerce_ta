namespace eCommerce.Domain.Entities
{
    public class ProductOption : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }  // "Color", "Size"
        public virtual ICollection<ProductOptionValue> ProductOptionValues { get; set; }
    }
}
