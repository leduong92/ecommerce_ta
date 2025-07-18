﻿using eCommerce.Application.Dtos;
using eCommerce.Shared.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Application.Interfaces
{
    public interface IAuthService
    {
        Task<ApiResponse<LoginResponseDto>> LoginAsync(LoginRequestDto loginRequestDto);
        Task<ApiResponse<UserDto>> RegisterAsync(RegisterationRequestDto registrationRequestDto);
        Task<ApiResponse<List<RegionDto>>> GetRegionsAsync();
        Task<ApiResponse<string>> AssignRoleAsync(RegisterationRequestDto registrationRequestDto);
    }
}
