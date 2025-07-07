using eCommerce.Application.Dtos;
using eCommerce.Shared.Common;
using eCommerce.Web.Services.IService;

namespace eCommerce.Application.Services
{
    public class LanguageApiClient : ILanguageApiClient
    {
        private readonly IBaseApiClient _baseApiClient;

        public LanguageApiClient(IBaseApiClient baseApiClient)
        {
            _baseApiClient = baseApiClient;
        }
		public async Task<ApiResponse<List<LanguageDto>>> GetLanguagesAsync()
        {
            return await _baseApiClient.SendAsync<List<LanguageDto>>(new RequestDto()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.ApiBaseUrl + "language"
            });
        }
    }
}
