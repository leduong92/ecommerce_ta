
namespace eCommerce.Domain.Entities
{
    public class ProductFabric  : BaseEntity
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string FabricCode { get; set; }
        public string Desccription { get; set; }
        public virtual UPHFabric UPHFabric { get; set; }
    }
}
