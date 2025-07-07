using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Application.Dtos
{
    public class OrderConfirmationDto
    {
        public string OrderId { get; set; }
        public decimal TotalAmount { get; set; }
        public string Currency { get; set; }
        public DateTime OrderDate { get; set; }
        public string CustomerEmail { get; set; } = "customer@example.com";
    }
}
