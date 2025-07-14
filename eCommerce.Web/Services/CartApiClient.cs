using Azure.Core;
using eCommerce.Application.Dtos;
using eCommerce.Domain.Entities;
using eCommerce.Shared.Common;
using eCommerce.Web.Services.IService;

namespace eCommerce.Web.Services
{
    public class CartApiClient : ICartApiClient
    {
        private readonly IBaseApiClient _baseApiClient;

        public CartApiClient(IBaseApiClient baseApiClient)
        {
            _baseApiClient = baseApiClient;
        }

        public async Task<ApiResponse<int>> AddItemToCartAsync(AddToCartRequestDto request)
        {
            return await _baseApiClient.SendAsync<int>(new RequestDto()
            {
                ApiType = SD.ApiType.POST,
                Data = request,
                Url = $"{SD.ApiBaseUrl}cart/add"
            });
        }

        public async Task<ApiResponse> ClearCartAsync()
        {
            return await _baseApiClient.SendAsync<ApiResponse>(new RequestDto()
            {
                ApiType = SD.ApiType.POST,
                Data = null,
                Url = $"{SD.ApiBaseUrl}cart/clear"
            });
        }

        public async Task<ApiResponse<List<CartItemDto>>> GetCartItemsAsync(string anonymousId)
        {
            return await _baseApiClient.SendAsync<List<CartItemDto>>(new RequestDto()
            {
                ApiType = SD.ApiType.GET,
                Url = $"{SD.ApiBaseUrl}cart?anonymousId={anonymousId}"
            });
        }

        public async Task<ApiResponse> MergeCartsAsync(MergeCartRequestDto request)
        {
            return await _baseApiClient.SendAsync<ApiResponse>(new RequestDto()
            {
                ApiType = SD.ApiType.POST,
                Data = request,
                Url = $"{SD.ApiBaseUrl}cart/merge"
            });
        }

        public async Task<ApiResponse<int>> RemoveItemFromCartAsync(RemoveFromCartRequest request)
        {
            return await _baseApiClient.SendAsync<int>(new RequestDto()
            {
                ApiType = SD.ApiType.DELETE,
                Data = request,
                Url = $"{SD.ApiBaseUrl}cart/remove"
            });
        }

        public async Task<ApiResponse<int>> UpdateItemQuantityAsync(UpdateQuantityRequestDto request)
        {
            return await _baseApiClient.SendAsync<int>(new RequestDto()
            {
                ApiType = SD.ApiType.PUT,
                Data = request,
                Url = $"{SD.ApiBaseUrl}cart/update"
            });
        }
    }
}
