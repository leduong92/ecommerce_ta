using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Application.Dtos
{
    public class CheckoutRequest
    {
        public string SessionId { get; set; } = string.Empty;
        public Guid? UserId { get; set; } // Optional, if logged in

        // Shipping Address
        public string ShippingFirstName { get; set; } = string.Empty;
        public string ShippingLastName { get; set; } = string.Empty;
        public string ShippingAddress1 { get; set; } = string.Empty;
        public string? ShippingAddress2 { get; set; }
        public string ShippingCity { get; set; } = string.Empty;
        public string ShippingStateProvince { get; set; } = string.Empty;
        public string ShippingZipCode { get; set; } = string.Empty;
        public string ShippingCountryCode { get; set; } = string.Empty;
        public double ShippingLatitude { get; set; }
        public double ShippingLongitude { get; set; }
        public string ShippingPhoneNumber { get; set; } = string.Empty;
        public int ShippingFloorNumber { get; set; } = 1;
        public bool ShippingIsRuralArea { get; set; } = false;

        // User's chosen shipping option (from a list provided by ShippingCalculatorService)
        public string ChosenShippingServiceLevelName { get; set; } = string.Empty;
        public List<OrderItemDetailsDto> OrderItemDetails { get; set; } = new List<OrderItemDetailsDto>();
    }
}
