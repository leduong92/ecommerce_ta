namespace eCommerce.Domain.Entities
{
    public class Product : BaseEntity
    {
        public int Id { get; set; }
        public string? Sku { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        public string? Name { get; set; } = string.Empty;
        public string? ExtendedDescription { get; set; } = string.Empty;
        public string? AdditionalFeatures { get; set; } = string.Empty;
        public string? Description { get; set; } = string.Empty;
        public string? MetaKeyword { get; set; } = string.Empty;
        public string? MetaDescription { get; set; } = string.Empty;
        public string? DefaultImageUrl { get; set; } = string.Empty;
        public decimal Depth { get; set; }
        public decimal Width { get; set; }
        public decimal Height { get; set; }
        public decimal NetWeightKg { get; set; }
        public decimal GrossWeightKg { get; set; }
        public decimal NetWeightLbs { get; set; }
        public decimal GrossWeightLbs { get; set; }
        public int? MaxHeight { get; set; } = 0;
        public int QuantityMultiplier { get; set; } = 1;
        public int CollectionId { get; set; }
        public virtual Collection Collection { get; set; } = null!;
        public int RoomId { get; set; }
        public virtual Room Room { get; set; } = null!;
        public int TypeId { get; set; }
        public virtual ProductType ProductType { get; set; }= null!;
        public int LifeStyleId { get; set; }
        public virtual LifeStyle LifeStyle { get; set; }= null!;
        public int StyleId { get; set; }
        public virtual Style Style { get; set; }= null!;
        public int ProductCategoryId { get; set; }
        public virtual ProductCategory ProductCategory { get; set; }= null!;
        public int? ProductShippingProfileId { get; set; }
        public ProductShippingProfile? ProductShippingProfile { get; set; }
        public virtual ICollection<ProductRegionAvailability>? RegionAvailabilities { get; set; }
        public virtual ICollection<ProductVariant>? Variants { get; set; }
        public virtual ICollection<ProductTranslation>? ProductTranslations { get; set; }
        public virtual ICollection<ProductPrice>? Prices { get; set; }
        // NEW: Add this collection to link Product to its InventoryItems
        // A product can exist in inventory at multiple warehouses.
        public ICollection<InventoryItem>? InventoryItems { get; set; }
        public virtual ICollection<Care>? Cares { get; set; }
    }
}
