using eCommerce.Application.Dtos;
using eCommerce.Application.Interfaces;
using eCommerce.Infrastructure.Data;
using eCommerce.Shared.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Application.Services
{
    public class AuthService : IAuthService
    {
        private readonly AppDbContext _context;
        public AuthService(AppDbContext context)
        {
            _context = context;
        }
        public Task<ApiResponse<string>> AssignRoleAsync(RegisterationRequestDto registrationRequestDto)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse<List<RegionDto>>> GetRegionsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse<LoginResponseDto>> LoginAsync(LoginRequestDto loginRequestDto)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse<UserDto>> RegisterAsync(RegisterationRequestDto registrationRequestDto)
        {
            throw new NotImplementedException();
        }
    }
}
