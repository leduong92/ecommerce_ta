using eCommerce.Shared.Common;

namespace eCommerce.Application.Interface
{
    public interface IBaseApiClient
    {
        Task<ApiResponse<T>> SendAsync<T>(RequestDto request, bool withBearer = true, CancellationToken cancellationToken = default);
    }
}
