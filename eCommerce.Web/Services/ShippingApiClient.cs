using eCommerce.Application.Dtos;
using eCommerce.Shared.Common;
using eCommerce.Web.Services.IService;

namespace eCommerce.Web.Services
{
    public class ShippingApiClient : IShippingApiClient
    {
        private readonly IBaseApiClient _baseApiClient;

        public ShippingApiClient(IBaseApiClient baseApiClient)
        {
            _baseApiClient = baseApiClient;
        }

        public async Task<ApiResponse<List<ShippingRouteOptionDto>>> CalculateShipping(CheckoutRequest request)
        {
            return await _baseApiClient.SendAsync<List<ShippingRouteOptionDto>>(new RequestDto()
            {
                ApiType = SD.ApiType.POST,
                Data = request,
                Url = $"{SD.ApiBaseUrl}shipping/calculate-shipping"
            });
        }
    }
}
