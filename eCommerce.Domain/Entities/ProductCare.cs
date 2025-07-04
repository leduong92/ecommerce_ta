
namespace eCommerce.Domain.Entities
{
    public class ProductCare : BaseEntity
    {
        public int ProductId { get; set; }
        public Product  Product { get; set; }
        public int CareId { get; set; }
        public Care Care { get; set; }
    }
}
