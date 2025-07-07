using eCommerce.Application.Dtos;
using eCommerce.Shared.Common;

namespace eCommerce.Application.Interfaces
{
    public interface ILanguageService
    {
        Task<ApiResponse<List<LanguageDto>>> GetLanguagesAsync();
    }
}
