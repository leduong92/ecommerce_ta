using eCommerce.Application.Dtos;
using eCommerce.Shared.Common;
using System.Drawing;
namespace eCommerce.Application.Interfaces
{
    public interface IProductService
    {
        Task<ApiResponse<IEnumerable<ProductListDto>>> GetProductsByRegionAsync(string regionCode, double? customerLatitude, double? customerLongitude);
        Task<ApiResponse<ProductDetailDto>?> GetProductDetailsAsync(int productId, string regionCode, double? customerLatitude, double? customerLongitude, int? colorId = null, int? sizeId = null);
        Task<ApiResponse<List<InventoryItemDto>>> GetAvailableWarehousesAsync();
        Task<ApiResponse<VariantDto>> GetVariantAsync(int productId, int? colorId = null, int? sizeId = null);
    }
}
