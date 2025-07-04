using System.ComponentModel.DataAnnotations;

namespace eCommerce.Domain.Entities
{
    public class BaseEntity
    {
        public bool IsActive { get; set; } = true;
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; } = DateTime.UtcNow;
        public string? UpdatedBy { get; set; }
        public DateTime? UpdateddAt { get; set; }
    }
}
