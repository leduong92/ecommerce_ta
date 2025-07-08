namespace eCommerce.Domain.Entities
{
    public class ProductTranslation : BaseEntity
    {
        public int ProductId { get; set; }
        public int LanguageId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? MetaKeyword { get; set; }
        public string? MetaDescription { get; set; }
        public Product Product { get; set; }
    }
}
