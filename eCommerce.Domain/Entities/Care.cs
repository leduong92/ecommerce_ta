namespace eCommerce.Domain.Entities
{
    public class Care : BaseEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? ContentTitle { get; set; }
        public string? ContentBody { get; set; }
        public string? ContentImageS7 { get; set; }
        public int? SortOrder { get; set; }
        public string? DisplayName { get; set; }
        public string? IamgeUrl { get; set; }
    }
}
