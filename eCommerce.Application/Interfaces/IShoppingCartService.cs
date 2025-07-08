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
        Task<Cart> GetOrCreateCartAsync(Guid userId);
        Task<Cart> AddToCartAsync(string sessionId, int productId, int quantity, string customerRegionCode, Guid userId);
        Task<Cart> UpdateCartItemQuantityAsync(string sessionId, int productId, int quantity, Guid userId);
        Task<Cart> RemoveFromCartAsync(string sessionId, int productId, Guid userId);
        Task ClearCartAsync(string sessionId, Guid userId);
        Task<List<CartItem>> GetCartItemsAsync(string sessionId, Guid userId);
        Task<int> GetCartItemCountAsync(Guid? userId);
        Task MergeCartsAsync(Guid? anonymousUserId, Guid? authenticatedUserId);
    }
}
