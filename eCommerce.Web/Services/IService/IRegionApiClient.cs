using eCommerce.Shared.Common;
using eCommerce.Application.Dtos;

namespace eCommerce.Web.Services
{
    public interface IRegionApiClient
    {
        Task<ApiResponse<List<RegionDto>>> GetRegionsAsync();
    }
}
