using System.ComponentModel.DataAnnotations;

namespace eCommerce.Domain.Entities
{
    public class Language : BaseEntity
    {
        public int Id { get; set; }
        public string? Code { get; set; } // ISO 3166-1 alpha-2 (e.g., VN, US)
        public string? Name { get; set; }
        public bool IsDefault { get; set; }
    }
}
