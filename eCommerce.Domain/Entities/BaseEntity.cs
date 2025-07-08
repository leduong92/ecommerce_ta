using System.ComponentModel.DataAnnotations;

namespace eCommerce.Domain.Entities
{
    public class BaseEntity
    {
        public bool IsActive { get; set; } = true;
        [MaxLength(64)]
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; } = DateTime.UtcNow;
        [MaxLength(64)]
        public string? UpdatedBy { get; set; }
        public DateTime? UpdateddAt { get; set; }
    }
}
