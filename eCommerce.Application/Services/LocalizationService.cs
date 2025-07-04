using eCommerce.Application.Dtos;
using eCommerce.Application.Interface;
using eCommerce.Shared.Common;

namespace eCommerce.Application.Services
{
    public class LocalizationService : ILocalizationService
    {
        private readonly IBaseApiClient _baseApiClient;

        public LocalizationService(IBaseApiClient baseApiClient)
        {
            _baseApiClient = baseApiClient;
        }
		public async Task<ApiResponse<List<LanguageDto>>> GetLocalizationsAsync()
        {
            return await _baseApiClient.SendAsync<List<LanguageDto>>(new RequestDto()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.ApiBaseUrl + "/api/localization"
            });
        }
    }
}
