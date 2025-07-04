using System.ComponentModel.DataAnnotations;

namespace eCommerce.Domain.Entities
{
    public class Coupon : BaseEntity
    {
        public int Id { get; set; }
        [MaxLength(8)]
        public string CouponCode { get; set; }
        public double DiscountAmount { get; set; }
        public int MinAmount { get; set; }
        public bool IsPublished { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
    }
}
