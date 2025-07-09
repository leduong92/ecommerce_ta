using eCommerce.Application.Dtos;
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
        Task<Cart> GetOrCreateCartAsync(Guid? userId, string? anonymousId);
        Task<Cart> AddToCartAsync(int productId, int quantity, string customerRegionCode, Guid userId, string? anonymousId);
        Task<Cart> UpdateCartItemQuantityAsync(int productId, int quantity, Guid userId, string? anonymousId);
        Task<Cart> RemoveFromCartAsync(int productId, Guid userId, string? anonymousId);
        Task ClearCartAsync(Guid userId, string? anonymousId);
        Task<ApiResponse<List<CartItemDto>>> GetCartItemsAsync(Guid userId, string? anonymousId);
        Task<int> GetCartItemCountAsync(Guid? userId);
        Task MergeCartsAsync(Guid? authenticatedUserId, string? anonymousId);
    }
}
