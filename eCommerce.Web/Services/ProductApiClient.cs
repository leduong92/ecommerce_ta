using eCommerce.Application.Dtos;
using eCommerce.Shared.Common;
using eCommerce.Web.Services.IService;

namespace eCommerce.Web.Services
{
    public class ProductApiClient : IProductApiClient
    {
        private readonly IBaseApiClient _baseApiClient;

        public ProductApiClient(IBaseApiClient baseApiClient)
        {
            _baseApiClient = baseApiClient;
        }

        public async Task<ApiResponse<ProductDetailDto>> GetProductDetail(int productId, string regionCode, string? latitude, string? longitude)
        {
            string requestUrl = $"{SD.ApiBaseUrl}product/{productId}/detail/{regionCode}";
            if (!string.IsNullOrEmpty(latitude) && !string.IsNullOrEmpty(longitude))
            {
                requestUrl += $"?latitude={latitude}&longitude={longitude}";
            }
            return await _baseApiClient.SendAsync<ProductDetailDto>(new RequestDto()
            {
                ApiType = SD.ApiType.GET,
                Url = requestUrl,
            });
        }

        public async Task<ApiResponse<List<ProductListDto>>> GetProductsByRegion(string regionCode, string? latitude, string? longitude)
        {
            string requestUrl = $"{SD.ApiBaseUrl}product/by-region/{regionCode}";
            if (!string.IsNullOrEmpty(latitude) && !string.IsNullOrEmpty(longitude))
            {
                requestUrl += $"?latitude={latitude}&longitude={longitude}";
            }
            return await _baseApiClient.SendAsync<List<ProductListDto>>(new RequestDto()
            {
                ApiType = SD.ApiType.GET,
                Url = requestUrl,
            });
        }
    }
}
