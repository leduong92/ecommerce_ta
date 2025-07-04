using System.ComponentModel.DataAnnotations;

namespace eCommerce.Domain.Entities
{
    public enum OrderStatus
    {
        PendingPayment,
        Processing,
        Shipped,
        Delivered,
        Cancelled,
        Returned
    }
    public class Order : BaseEntity
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }  // The user who placed the order
        public DateTime OrderDate { get; set; }
        public OrderStatus Status { get; set; }

        // Shipping Address Details
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

        // Financials
        public decimal Subtotal { get; set; } // Sum of all OrderItem prices
        public decimal ShippingCost { get; set; } // The calculated shipping cost
        public decimal TotalAmount { get; set; } // Subtotal + ShippingCost

        // Shipping Method chosen by customer
        public string ChosenShippingServiceLevelName { get; set; } = string.Empty;
        public string ChosenShippingDeliveryType { get; set; } = string.Empty;
        public int ChosenShippingEstimatedDaysMin { get; set; }
        public int ChosenShippingEstimatedDaysMax { get; set; }
        public string ChosenShippingOriginWarehouseName { get; set; } = string.Empty;
        public string ChosenShippingRouteDescription { get; set; } = string.Empty; // Full route description

        // Inventory Allocation
        public int? FulfillingWarehouseId { get; set; }
        public Warehouse? FulfillingWarehouse { get; set; } // The warehouse from which the order will be fulfilled

        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}
