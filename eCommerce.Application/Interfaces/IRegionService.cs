using eCommerce.Shared.Common;
using eCommerce.Application.Dtos;

namespace eCommerce.Application.Interface
{
    public interface IRegionService
    {
        Task<ApiResponse<List<RegionDto>>> GetRegionsAsync();
    }
}
