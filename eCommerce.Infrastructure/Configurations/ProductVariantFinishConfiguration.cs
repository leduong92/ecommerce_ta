using eCommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace eCommerce.Infrastructure.Configurations
{
    public class ProductVariantFinishConfiguration : IEntityTypeConfiguration<ProductVariantFinish>
    {
        public void Configure(EntityTypeBuilder<ProductVariantFinish> builder)
        {
            builder.ToTable("ProductVariantFinishs");

            builder.HasKey(pv => new { pv.ProductVariantId, pv.FinishId });

            builder.Property(x => x.PriceAdjustment).HasColumnType("decimal(18,2)");

            builder.HasOne(pv => pv.ProductVariant)
                        .WithMany(v => v.ProductVariantFinishes)
                        .HasForeignKey(pv => pv.ProductVariantId);

            builder.HasOne(pv => pv.Finish)
                        .WithMany(ov => ov.ProductVariantFinishes)
                        .HasForeignKey(pv => pv.FinishId);

        }
    }
}
