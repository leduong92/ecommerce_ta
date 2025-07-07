using eCommerce.Application.Dtos;
using eCommerce.Shared.Common;
using eCommerce.Web.Services.IService;


namespace eCommerce.Web.Services
{
    public class CouponApiClient : ICouponApiClient
    {
        private readonly IBaseApiClient _baseApiClient;

        public CouponApiClient(IBaseApiClient baseApiClient)
        {
            _baseApiClient = baseApiClient;
        }

		public async Task<ApiResponse<CouponDto>> CreateCouponsAsync(CouponDto couponDto)
		{
			return await _baseApiClient.SendAsync<CouponDto>(new RequestDto()
			{
				ApiType = SD.ApiType.POST,
				Data = couponDto,
				Url = SD.ApiBaseUrl + "coupon"
			});
		}

		public async Task<ApiResponse<List<CouponDto>>> GetAllCouponsAsync()
        {
            return await _baseApiClient.SendAsync<List<CouponDto>>(new RequestDto()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.ApiBaseUrl + "coupon"
            });
        }

        public async Task<ApiResponse<CouponDto>> GetCouponAsync(string couponCode)
        {
            return await _baseApiClient.SendAsync<CouponDto>(new RequestDto()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.ApiBaseUrl + "coupon/GetByCode/" + couponCode
            });
        }
    }
}
