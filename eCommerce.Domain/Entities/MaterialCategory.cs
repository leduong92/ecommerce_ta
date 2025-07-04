namespace eCommerce.Domain.Entities
{
    public class MaterialCategory : BaseEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public virtual ICollection<Material> Materials { get; set; }
    }
}
