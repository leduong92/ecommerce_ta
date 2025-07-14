using eCommerce.Application.Dtos;
using eCommerce.Domain.Entities;
using eCommerce.Shared.Common;

namespace eCommerce.Web.Services.IService
{
    public interface IOrderApiClient
    {
        Task<ApiResponse<Order?>> ProcessCheckoutAsync(CheckoutRequest checkoutRequest);
        Task<ApiResponse<bool>> UpdateOrderStatusAsync(int orderId, OrderStatus newStatus);
        Task<ApiResponse<bool>> ConfirmShipmentAndUpdateInventoryAsync(int orderId);
        Task<ApiResponse<Order?>> GetOrderByIdAsync(int orderId);
    }
}
