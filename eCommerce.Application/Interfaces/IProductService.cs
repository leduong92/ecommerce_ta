using eCommerce.Application.Dtos;
namespace eCommerce.Application.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<ProductListDto>> GetProductsByRegionAsync(string regionCode, double? customerLatitude, double? customerLongitude);
        Task<ProductDetailDto?> GetProductDetailsAsync(int productId, string regionCode, double? customerLatitude, double? customerLongitude);
    }
}
