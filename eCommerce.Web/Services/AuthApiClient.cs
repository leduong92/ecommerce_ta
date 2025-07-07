
using eCommerce.Application.Dtos;
using eCommerce.Shared.Common;
using eCommerce.Web.Services.IService;

namespace eCommerce.Web.Services
{
    public class AuthApiClient : IAuthApiClient
    {
        private readonly IBaseApiClient _baseService;
        public AuthApiClient(IBaseApiClient baseService)
        {
            _baseService = baseService;
        }

        public async Task<ApiResponse<string>> AssignRoleAsync(RegisterationRequestDto registrationRequestDto)
        {
            return await _baseService.SendAsync<string>(new RequestDto()
            {
                ApiType = SD.ApiType.POST,
                Data = registrationRequestDto,
                Url = SD.ApiBaseUrl + "auth/AssignRole"
            });
        }

        public async Task<ApiResponse<List<RegionDto>>> GetRegionsAsync()
        {
            return await _baseService.SendAsync<List<RegionDto>>(new RequestDto()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.ApiBaseUrl + "auth/region"
            });
        }

        public async Task<ApiResponse<LoginResponseDto>> LoginAsync(LoginRequestDto loginRequestDto)
        {
            return await _baseService.SendAsync<LoginResponseDto>(new RequestDto()
            {
                ApiType = SD.ApiType.POST,
                Data = loginRequestDto,
                Url = SD.ApiBaseUrl + "auth/login"
            }, withBearer: false);
        }

        public async Task<ApiResponse<UserDto>> RegisterAsync(RegisterationRequestDto registrationRequestDto)
        {
            return await _baseService.SendAsync<UserDto>(new RequestDto()
            {
                ApiType = SD.ApiType.POST,
                Data = registrationRequestDto,
                Url = SD.ApiBaseUrl + "auth/register"
            }, withBearer: false);
        }
    }
}
