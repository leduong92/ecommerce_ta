namespace eCommerce.Shared.Common
{
    public class PagedResult<T>
    {
        public List<T>? Items { get; set; }
        public int TotalRecords { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public int PageCount => (int)Math.Ceiling((double)TotalRecords / PageSize);

    }
  
}
