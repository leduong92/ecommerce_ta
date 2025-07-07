using Microsoft.EntityFrameworkCore;
using eCommerce.Application.Dtos;
using eCommerce.Application.Interfaces;
using eCommerce.Infrastructure.Data;
using eCommerce.Shared.Common;

namespace eCommerce.Application.Services
{
    public class LanguageService : ILanguageService
    {
        private readonly AppDbContext _context;

        public LanguageService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<ApiResponse<List<LanguageDto>>> GetLanguagesAsync()
        {
            var response = await _context.Languages.Where(x => x.IsActive == true).Select(x => new LanguageDto
            {
                Id = x.Id,
                Name = x.Name,
                Code = x.Code
            }).ToListAsync();

            return ApiResponse<List<LanguageDto>>.Success(response);
        }
    }
}
