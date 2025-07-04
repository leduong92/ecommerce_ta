
using eCommerce.Application.Dtos;
using eCommerce.Shared.Common;

namespace eCommerce.Application.Interface
{
    public interface IAuthService
    {
        Task<ApiResponse<LoginResponseDto>> LoginAsync(LoginRequestDto loginRequestDto);
        Task<ApiResponse<UserDto>> RegisterAsync(RegisterationRequestDto registrationRequestDto);
        Task<ApiResponse<List<RegionDto>>> GetRegionsAsync();
        Task<ApiResponse<string>> AssignRoleAsync(RegisterationRequestDto registrationRequestDto);
    }
}
