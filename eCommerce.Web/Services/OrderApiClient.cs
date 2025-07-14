using eCommerce.Application.Dtos;
using eCommerce.Domain.Entities;
using eCommerce.Shared.Common;
using eCommerce.Web.Services.IService;

namespace eCommerce.Web.Services
{
    public class OrderApiClient : IOrderApiClient
    {
        private readonly IBaseApiClient _baseApiClient;

        public OrderApiClient(IBaseApiClient baseApiClient)
        {
            _baseApiClient = baseApiClient;
        }
        public Task<ApiResponse<bool>> ConfirmShipmentAndUpdateInventoryAsync(int orderId)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse<Order?>> GetOrderByIdAsync(int orderId)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse<Order?>> ProcessCheckoutAsync(CheckoutRequest checkoutRequest)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse<bool>> UpdateOrderStatusAsync(int orderId, OrderStatus newStatus)
        {
            throw new NotImplementedException();
        }
    }
}
