
using eCommerce.Shared.Common;
using eCommerce.Application.Dtos;

namespace eCommerce.Web.Services.IService
{
    public interface ILanguageApiClient
    {
        Task<ApiResponse<List<LanguageDto>>> GetLanguagesAsync();
    }
}
