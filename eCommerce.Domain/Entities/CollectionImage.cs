namespace eCommerce.Domain.Entities
{
    public class CollectionImage : BaseEntity
    {
        public int Id { get; set; }
        public int CollectionId { get; set; }
        public string? ImageUrl { get; set; }
        public int SortOrder { get; set; }
        public int ImageType { get; set; } //Video or Image

    }
}
