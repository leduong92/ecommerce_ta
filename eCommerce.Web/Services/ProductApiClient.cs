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

        public async Task<ApiResponse<ProductDetailDto>> GetProductDetail(
            int productId, 
            string regionCode, 
            string? latitude, 
            string? longitude, 
            int? sizeId = null, 
            int? fabricId = null,
            int? finishId = null)
        {
            string requestUrl = $"{SD.ApiBaseUrl}product/{productId}/detail/{regionCode}";

            var queryParams = new List<string>();

            if (!string.IsNullOrEmpty(latitude)) queryParams.Add($"latitude={latitude}");
            if (!string.IsNullOrEmpty(longitude)) queryParams.Add($"longitude={longitude}");
            if (sizeId.HasValue) queryParams.Add($"sizeId={sizeId}");
            if (fabricId.HasValue) queryParams.Add($"fabricId={fabricId}");
            if (finishId.HasValue) queryParams.Add($"finishId={finishId}");

            if (queryParams.Any())
                requestUrl += "?" + string.Join("&", queryParams);

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

        public async Task<ApiResponse<VariantDto>> GetVariantAsync(int productId, int? sizeId, int? fabricId, int? finishId)
        {
            return await _baseApiClient.SendAsync<VariantDto>(new RequestDto()
            {
                ApiType = SD.ApiType.GET,
                Url = $"{SD.ApiBaseUrl}product/{productId}/GetVariant?sizeId={sizeId}&fabricId={fabricId}&finishId={finishId}",
            });
        }
    }
}
