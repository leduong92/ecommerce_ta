using eCommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace eCommerce.Infrastructure.Configurations
{
    public class ProductVariantFabricConfiguration : IEntityTypeConfiguration<ProductVariantFabric>
    {
        public void Configure(EntityTypeBuilder<ProductVariantFabric> builder)
        {
            builder.ToTable("ProductVariantFabrics");

            builder.HasKey(pv => new { pv.ProductVariantId, pv.FabricId });

            builder.HasOne(pv => pv.ProductVariant)
                        .WithMany(v => v.ProductVariantFabrics)
                        .HasForeignKey(pv => pv.ProductVariantId);

            builder.HasOne(pv => pv.Fabric)
                        .WithMany(ov => ov.ProductVariantFabrics)
                        .HasForeignKey(pv => pv.FabricId);

        }
    }
}
