using eCommerce.Application.Dtos;
using eCommerce.Shared.Common;
namespace eCommerce.Application.Interfaces
{
    public interface IProductService
    {
        Task<ApiResponse<IEnumerable<ProductListDto>>> GetProductsByRegionAsync(string regionCode, double? customerLatitude, double? customerLongitude);
        Task<ApiResponse<ProductDetailDto>?> GetProductDetailsAsync(int productId, string regionCode, double? customerLatitude, double? customerLongitude);
        Task<ApiResponse<List<InventoryItemDto>>> GetAvailableWarehousesAsync();
    }
}
