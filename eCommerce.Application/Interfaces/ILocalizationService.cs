
using eCommerce.Shared.Common;
using eCommerce.Application.Dtos;

namespace eCommerce.Application.Interface
{
    public interface ILocalizationService
    {
        Task<ApiResponse<List<LanguageDto>>> GetLocalizationsAsync();
    }
}
