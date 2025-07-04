using eCommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace eCommerce.Infrastructure.Configurations
{
    public class ProductVariantOptionValueConfiguration : IEntityTypeConfiguration<ProductVariantOptionValue>
    {
        public void Configure(EntityTypeBuilder<ProductVariantOptionValue> builder)
        {
            builder.ToTable("ProductVariantOptionValues");

            builder.HasKey(pv => new { pv.ProductVariantId, pv.ProductOptionValueId });

            builder.HasOne(pv => pv.ProductVariant)
                        .WithMany(v => v.ProductVariantOptionValues)
                        .HasForeignKey(pv => pv.ProductVariantId);

            builder.HasOne(pv => pv.ProductOptionValue)
                        .WithMany()
                        .HasForeignKey(pv => pv.ProductOptionValueId);

        }
    }
}
