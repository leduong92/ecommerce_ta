

using eCommerce.Shared.Common;
using eCommerce.Application.Dtos;

namespace eCommerce.Web.Services.IService
{
    public interface ICouponApiClient
    {
        Task<ApiResponse<CouponDto>> GetCouponAsync(string couponCode);
        Task<ApiResponse<List<CouponDto>>> GetAllCouponsAsync();
		Task<ApiResponse<CouponDto>> CreateCouponsAsync(CouponDto couponDto);
	}
}
