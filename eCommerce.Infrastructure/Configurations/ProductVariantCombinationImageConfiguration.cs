using eCommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace eCommerce.Infrastructure.Configurations
{
    public class ProductVariantCombinationImageConfiguration : IEntityTypeConfiguration<ProductVariantCombinationImage>
    {
        public void Configure(EntityTypeBuilder<ProductVariantCombinationImage> builder)
        {
            builder.ToTable("ProductVariantCombinationImages");

            builder.HasKey(p => p.Id);

            builder.HasIndex(p => new {
                p.ProductVariantId,
                p.FabricId,
                p.FinishId,
                p.ProductOptionValueId
            }).IsUnique();

            builder.Property(p => p.ImageUrl)
                .IsRequired()
                .HasMaxLength(1024);

            builder.Property(p => p.IsPrimary)
                .HasDefaultValue(false);

        }
    }
}
