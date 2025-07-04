using eCommerce.Application.Interface;
using eCommerce.Shared.Common;
using eCommerce.Application.Dtos;

namespace eCommerce.Application.Services
{
    public class RegionService : IRegionService
    {
        private readonly IBaseApiClient _baseApiClient;

        public RegionService(IBaseApiClient baseApiClient)
        {
            _baseApiClient = baseApiClient;
        }
		public async Task<ApiResponse<List<RegionDto>>> GetRegionsAsync()
        {
            return await _baseApiClient.SendAsync<List<RegionDto>>(new RequestDto()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.RegionAPIBase + "/api/region"
            });
        }
    }
}
