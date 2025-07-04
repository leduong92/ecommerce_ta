using System.ComponentModel.DataAnnotations;

namespace eCommerce.Domain.Entities
{
    public class Payment : BaseEntity
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public decimal Amount { get; set; }
        public string CurrencyCode { get; set; }
        public string Status { get; set; }
        public string PaymentMethod { get; set; }
    }
}
