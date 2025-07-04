namespace eCommerce.Domain.Entities
{
    public class Material : BaseEntity
    {
        public int Id { get; set; }
        public int MaterialCategoryId { get; set; }
        public string? Name { get; set; }
        public int SortOrder { get; set; }
    }
}
