
using eCommerce.Application.Dtos;
using eCommerce.Application.Interface;
using eCommerce.Shared.Common;

namespace eCommerce.Application.Services
{
    public class AuthService : IAuthService
    {
        private readonly IBaseApiClient _baseService;
        public AuthService(IBaseApiClient baseService)
        {
            _baseService = baseService;
        }

        public async Task<ApiResponse<string>> AssignRoleAsync(RegisterationRequestDto registrationRequestDto)
        {
            return await _baseService.SendAsync<string>(new RequestDto()
            {
                ApiType = SD.ApiType.POST,
                Data = registrationRequestDto,
                Url = SD.ApiBaseUrl + "/api/auth/AssignRole"
            });
        }

        public async Task<ApiResponse<List<RegionDto>>> GetRegionsAsync()
        {
            return await _baseService.SendAsync<List<RegionDto>>(new RequestDto()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.ApiBaseUrl + "/api/auth/region"
            });
        }

        public async Task<ApiResponse<LoginResponseDto>> LoginAsync(LoginRequestDto loginRequestDto)
        {
            return await _baseService.SendAsync<LoginResponseDto>(new RequestDto()
            {
                ApiType = SD.ApiType.POST,
                Data = loginRequestDto,
                Url = SD.ApiBaseUrl + "/api/auth/login"
            }, withBearer: false);
        }

        public async Task<ApiResponse<UserDto>> RegisterAsync(RegisterationRequestDto registrationRequestDto)
        {
            return await _baseService.SendAsync<UserDto>(new RequestDto()
            {
                ApiType = SD.ApiType.POST,
                Data = registrationRequestDto,
                Url = SD.ApiBaseUrl + "/api/auth/register"
            }, withBearer: false);
        }
    }
}
