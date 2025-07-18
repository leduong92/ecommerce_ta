﻿using eCommerce.Application.Dtos;
using eCommerce.Shared.Common;

namespace eCommerce.Application.Interfaces
{
    public interface IRegionService
    {
        Task<ApiResponse<List<RegionDto>>> GetRegionsAsync();
    }
}
