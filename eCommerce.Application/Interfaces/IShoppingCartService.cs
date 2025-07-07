using eCommerce.Domain.Entities;
using eCommerce.Shared.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Application.Interfaces
{
    public interface IShoppingCartService
    {
        Task<Cart> GetOrCreateCartAsync(string sessionId, Guid? userId = null);
        Task<Cart> AddToCartAsync(string sessionId, int productId, int quantity, string customerRegionCode, Guid? userId = null);
        Task<Cart> UpdateCartItemQuantityAsync(string sessionId, int productId, int quantity, Guid? userId = null);
        Task<Cart> RemoveFromCartAsync(string sessionId, int productId, Guid? userId = null);
        Task ClearCartAsync(string sessionId, Guid? userId = null);
        Task<List<CartItem>> GetCartItemsAsync(string sessionId, Guid? userId = null);
    }
}
