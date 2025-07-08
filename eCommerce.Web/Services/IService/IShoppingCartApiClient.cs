using eCommerce.Application.Dtos;
using eCommerce.Shared.Common;

namespace eCommerce.Web.Services.IService
{
    public interface IShoppingCartApiClient
    {
        Task<ApiResponse<List<CartItemDto>>> GetCartItemsAsync(); // Returns a list of DTOs
        Task<ApiResponse<int>> AddItemToCartAsync(AddToCartRequestDto request); // Returns new item count
        Task<ApiResponse<int>> UpdateItemQuantityAsync(UpdateQuantityRequestDto  request); // Returns new item count
        Task<ApiResponse<int>> RemoveItemFromCartAsync(int productId); // Returns new item count
        Task<ApiResponse> ClearCartAsync(); // Clears cart via API
        Task<ApiResponse> MergeCartsAsync(MergeCartRequestDto request); // Call API to merge
    }
}
