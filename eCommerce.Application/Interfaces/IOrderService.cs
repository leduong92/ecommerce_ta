using eCommerce.Application.Dtos;
using eCommerce.Domain.Entities;


namespace eCommerce.Application.Interfaces
{
    public interface IOrderService
    {
        Task<Order?> ProcessCheckoutAsync(CheckoutRequest checkoutRequest);
        Task<bool> UpdateOrderStatusAsync(int orderId, OrderStatus newStatus);
        Task<bool> ConfirmShipmentAndUpdateInventoryAsync(int orderId);
        Task<Order?> GetOrderByIdAsync(int orderId);
    }
}
