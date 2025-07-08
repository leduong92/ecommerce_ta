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
        Task<Cart> AddToCartAsync(int productId, int quantity, string customerRegionCode, Guid userId);
        Task<Cart> UpdateCartItemQuantityAsync(int productId, int quantity, Guid userId);
        Task<Cart> RemoveFromCartAsync(int productId, Guid userId);
        Task ClearCartAsync(Guid userId);
        Task<List<CartItem>> GetCartItemsAsync(Guid userId);
        Task<int> GetCartItemCountAsync(Guid? userId);
        Task MergeCartsAsync(Guid? anonymousUserId, Guid? authenticatedUserId);
    }
}
