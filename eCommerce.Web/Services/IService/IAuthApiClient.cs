
using eCommerce.Application.Dtos;
using eCommerce.Shared.Common;

namespace eCommerce.Web.Services.IService
{
    public interface IAuthApiClient
    {
        Task<ApiResponse<LoginResponseDto>> LoginAsync(LoginRequestDto loginRequestDto);
        Task<ApiResponse<UserDto>> RegisterAsync(RegisterationRequestDto registrationRequestDto);
        Task<ApiResponse<List<RegionDto>>> GetRegionsAsync();
        Task<ApiResponse<string>> AssignRoleAsync(RegisterationRequestDto registrationRequestDto);
    }
}
