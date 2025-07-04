using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Application.Dtos
{
    public class ShippingCalculationRequest
    {
        public string DestinationCountryCode { get; set; } = string.Empty;
        public string? DestinationStateProvince { get; set; }
        public string? DestinationZipCode { get; set; }
        public double DestinationLatitude { get; set; } // Critical for nearest warehouse
        public double DestinationLongitude { get; set; } // Critical for nearest warehouse
        public List<OrderItemDetailsDto> OrderItems { get; set; } = new List<OrderItemDetailsDto>();
        public decimal TotalOrderValue { get; set; }
        public int DestinationFloorNumber { get; set; } = 1;
        public bool IsRuralArea { get; set; } = false;
    }
}
