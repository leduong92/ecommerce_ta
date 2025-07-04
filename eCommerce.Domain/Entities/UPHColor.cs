
namespace eCommerce.Domain.Entities
{
    public class UPHColor : BaseEntity
    {
        public int Id { get; set; }
        public string Colour { get; set; }
        public string Code { get; set; }
        public string CodeHex { get; set; }
    }
}
