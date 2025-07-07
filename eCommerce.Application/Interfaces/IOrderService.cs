using eCommerce.Application.Dtos;
using eCommerce.Domain.Entities;
using eCommerce.Shared.Common;


namespace eCommerce.Application.Interfaces
{
    public interface IOrderService
    {
        Task<ApiResponse<Order?>> ProcessCheckoutAsync(CheckoutRequest checkoutRequest);
        Task<ApiResponse<bool>> UpdateOrderStatusAsync(int orderId, OrderStatus newStatus);
        Task<ApiResponse<bool>> ConfirmShipmentAndUpdateInventoryAsync(int orderId);
        Task<ApiResponse<Order?>> GetOrderByIdAsync(int orderId);
    }
}
