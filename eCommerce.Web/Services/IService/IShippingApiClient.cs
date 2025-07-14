using eCommerce.Application.Dtos;
using eCommerce.Shared.Common;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.Web.Services.IService
{
    public interface IShippingApiClient
    {
        Task<ApiResponse<List<ShippingRouteOptionDto>>> CalculateShipping(CheckoutRequest request);
    }
}
