using Microsoft.EntityFrameworkCore;
using eCommerce.Application.Dtos;
using eCommerce.Application.Interfaces;
using eCommerce.Infrastructure.Data;
using eCommerce.Shared.Common;

namespace eCommerce.Application.Services
{
    public class RegionService : IRegionService
    {
        private readonly AppDbContext _context;

        public RegionService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<ApiResponse<List<RegionDto>>> GetRegionsAsync()
        {
            var response = await _context.Regions.Select(x => new RegionDto
            {
                Id = x.Id,
                Name = x.Name,
                Code = x.Code,
                Currency = x.Currency,
                Description = x.Description,
                Latitude = x.Latitude,
                Longitude = x.Longitude,
            }).ToListAsync();

            return ApiResponse<List<RegionDto>>.Success(response);
        }
    }
}
