using eCommerce.Application.Interfaces;
using eCommerce.Application.Dtos;

namespace eCommerce.Application.Services
{
    public class ProductService : IProductService
    {
        public async Task<ProductDto> GetProductByIdAsync(long id, int regionId, int languageId)
        {
            throw new NotImplementedException();
        }
         
        public async Task<IEnumerable<ProductDto>> GetProductsAsync(int regionId, int languageId)
        {
            throw new NotImplementedException();
        }
    }
}
