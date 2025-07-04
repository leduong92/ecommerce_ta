using eCommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eCommerce.Infrastructure.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");
            builder.HasKey(p => p.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name).HasMaxLength(64);
            builder.Property(x => x.Sku).HasMaxLength(32);
            builder.Property(x => x.Slug).HasMaxLength(128);
            builder.Property(x => x.Description).HasColumnType("nvarchar(max)");
            builder.Property(x => x.MetaKeyword).HasMaxLength(256);
            builder.Property(x => x.MetaDescription).HasMaxLength(512);
            builder.Property(x => x.DefaultImageUrl).HasMaxLength(1024);
            builder.Property(x => x.IsActive).HasDefaultValue(true);
            builder.Property(x => x.Depth).HasColumnType("decimal(18,2)");
            builder.Property(x => x.Width).HasColumnType("decimal(18,2)");
            builder.Property(x => x.Height).HasColumnType("decimal(18,2)");
            builder.Property(x => x.NetWeightKg).HasColumnType("decimal(18,2)");
            builder.Property(x => x.GrossWeightKg).HasColumnType("decimal(18,2)");
            builder.Property(x => x.NetWeightLbs).HasColumnType("decimal(18,2)");
            builder.Property(x => x.GrossWeightLbs).HasColumnType("decimal(18,2)");
            builder.Property(x => x.QuantityMultiplier).HasDefaultValue(1);

            builder.HasOne(p => p.ProductType)
                    .WithMany()
                    .HasForeignKey(p => p.TypeId)
                    .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.Cares).WithMany().UsingEntity<ProductCare>();

            builder.HasOne(p => p.ProductCategory)
                   .WithMany()
                   .HasForeignKey(p => p.ProductCategoryId);

            builder.HasOne(p => p.ProductShippingProfile) // Link Product to ProductShippingProfile
                  .WithMany(psp => psp.Products)
                  .HasForeignKey(p => p.ProductShippingProfileId)
                  .IsRequired(false);

        }
    }
}
