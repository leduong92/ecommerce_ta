using Azure.Core;
using eCommerce.Application.Dtos;
using eCommerce.Domain.Entities;
using eCommerce.Shared.Common;
using eCommerce.Web.Services.IService;

namespace eCommerce.Web.Services
{
    public class ShoppingCartApiClient : IShoppingCartApiClient
    {
        private readonly IBaseApiClient _baseApiClient;

        public ShoppingCartApiClient(IBaseApiClient baseApiClient)
        {
            _baseApiClient = baseApiClient;
        }

        public async Task<ApiResponse<int>> AddItemToCartAsync(AddToCartRequestDto request)
        {
            return await _baseApiClient.SendAsync<int>(new RequestDto()
            {
                ApiType = SD.ApiType.POST,
                Data = request,
                Url = $"{SD.ApiBaseUrl}Cart/add"
            });
        }

        public async Task<ApiResponse> ClearCartAsync()
        {
            return await _baseApiClient.SendAsync<ApiResponse>(new RequestDto()
            {
                ApiType = SD.ApiType.POST,
                Data = null,
                Url = $"{SD.ApiBaseUrl}Cart/clear"
            });
        }

        public async Task<ApiResponse<List<CartItemDto>>> GetCartItemsAsync()
        {
            return await _baseApiClient.SendAsync<List<CartItemDto>>(new RequestDto()
            {
                ApiType = SD.ApiType.GET,
                Url = $"{SD.ApiBaseUrl}Cart"
            });
        }

        public async Task<ApiResponse> MergeCartsAsync(MergeCartRequestDto request)
        {
            return await _baseApiClient.SendAsync<ApiResponse>(new RequestDto()
            {
                ApiType = SD.ApiType.POST,
                Data = request,
                Url = $"{SD.ApiBaseUrl}Cart/merge"
            });
        }

        public async Task<ApiResponse<int>> RemoveItemFromCartAsync(int productId)
        {
            return await _baseApiClient.SendAsync<int>(new RequestDto()
            {
                ApiType = SD.ApiType.DELETE,
                Url = $"{SD.ApiBaseUrl}Cart/remove/{productId}"
            });
        }

        public async Task<ApiResponse<int>> UpdateItemQuantityAsync(UpdateQuantityRequestDto request)
        {
            return await _baseApiClient.SendAsync<int>(new RequestDto()
            {
                ApiType = SD.ApiType.PUT,
                Data = request,
                Url = $"{SD.ApiBaseUrl}Cart/update"
            });
        }
    }
}
