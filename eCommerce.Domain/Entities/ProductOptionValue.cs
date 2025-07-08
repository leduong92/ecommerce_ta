
namespace eCommerce.Domain.Entities
{
    public class ProductOptionValue : BaseEntity
    {
        public int Id { get; set; }
        public int ProductOptionId { get; set; }
        public ProductOption Option { get; set; }
        public string Value { get; set; } // "Deep Black", "White"
    }
}
