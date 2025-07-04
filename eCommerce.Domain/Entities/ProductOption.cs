namespace eCommerce.Domain.Entities
{
    public class ProductOption
    {
        public int Id { get; set; }
        public string Name { get; set; }  // "Color", "Size"
        public virtual ICollection<ProductOptionValue> ProductOptionValues { get; set; }
    }
}
