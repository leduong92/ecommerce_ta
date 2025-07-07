using eCommerce.Application.Dtos;
using eCommerce.Shared.Common;
using eCommerce.Web.Services;
using eCommerce.Web.Services.IService;


namespace eCommerce.Application.Services
{
    public class RegionApiClient : IRegionApiClient
    {
        private readonly IBaseApiClient _baseApiClient;

        public RegionApiClient(IBaseApiClient baseApiClient)
        {
            _baseApiClient = baseApiClient;
        }
		public async Task<ApiResponse<List<RegionDto>>> GetRegionsAsync()
        {
            return await _baseApiClient.SendAsync<List<RegionDto>>(new RequestDto()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.ApiBaseUrl + "region"
            });
        }
    }
}
