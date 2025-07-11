namespace eCommerce.Domain.Entities
{
    public class UPHFabric : BaseEntity
    {
        public int Id { get; set; }
        public string? Fabric { get; set; }
        public int? Grade { get; set; }
        public string? Content1 { get; set; }
        public string? Content2 { get; set; }
        public string? Content3 { get; set; }
        public string? Content4 { get; set; }
        public string? Content5 { get; set; }
        public string? Content6 { get; set; }
        public string? Sampled { get; set; }
        public string? Color { get; set; }
        public string? ColorCode { get; set; }
        public string? Pattern { get; set; }
        public string? PatternCode { get; set; }
        public string? Vrepeat { get; set; }
        public string? Hrepeat { get; set; }
        public string? Width { get; set; }
        public string? CleaningCode { get; set; }
        public string? Application { get; set; }
        public string? Durability { get; set; }
        public bool? Enable { get; set; }
        public bool InStock { get; set; }
        public bool IsEnabledOnWeb { get; set; }
        public string? Name { get; set; }
        public bool? Rlc { get; set; }
        public string? GradeTrim { get; set; }
        public string? Category { get; set; }
        public string? CategoryTrim { get; set; }
        public string? Rubs { get; set; }
        public decimal? QtyOnHand { get; set; }
        public string? Um { get; set; }
        public bool? Pfp { get; set; }
        public string? ImageUrl { get; set; }
        public string? GradeVn { get; set; }
        public bool IsCustom { get; set; }
        public decimal? CustomPrice { get; set; }
        public ICollection<ProductVariantFabric> ProductVariantFabrics { get; set; } = new List<ProductVariantFabric>();
    }
}
