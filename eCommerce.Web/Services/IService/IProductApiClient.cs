using eCommerce.Application.Dtos;
using eCommerce.Shared.Common;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace eCommerce.Web.Services.IService
{
    public interface IProductApiClient
    {
        Task<ApiResponse<List<ProductListDto>>> GetProductsByRegion(string regionCode, string? latitude, string? longitude);
        Task<ApiResponse<ProductDetailDto>> GetProductDetail(
            int productId, 
            string regionCode, 
            string? latitude, 
            string? longitude, 
            int? sizeId = null, 
            int? fabricId = null,
            int? finishId = null);
        Task<ApiResponse<VariantDto>> GetVariantAsync(int productId, int? sizeId = null, int? fabricId = null, int? finishId = null);
    }
}
