

using eCommerce.Shared.Common;
using eCommerce.Application.Dtos;

namespace eCommerce.Application.Interface
{
    public interface ICouponService
    {
        Task<ApiResponse<CouponDto>> GetCouponAsync(string couponCode);
        Task<ApiResponse<List<CouponDto>>> GetAllCouponsAsync();
		Task<ApiResponse<CouponDto>> CreateCouponsAsync(CouponDto couponDto);
	}
}
