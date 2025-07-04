namespace eCommerce.Shared.Common;
public class GetManagePagingRequest : PagingRequestBase
{
    public string? Searchterm { get; set; } = string.Empty;
    public string? SortKey { get; set; } = string.Empty;
    public bool? IsBarstool { get; set; } = false;
}