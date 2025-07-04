using eCommerce.Application.Dtos;
namespace eCommerce.Application.Interfaces
{
    internal interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetProductsAsync(int regionId, int languageId);
        Task<ProductDto> GetProductByIdAsync(long id, int regionId, int languageId);
    }
}
