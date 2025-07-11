using eCommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace eCommerce.Infrastructure.Configurations
{
    public class ProductVariantFinishImageConfiguration : IEntityTypeConfiguration<ProductVariantFinishImage>
    {
        public void Configure(EntityTypeBuilder<ProductVariantFinishImage> builder)
        {
            builder.ToTable("ProductVariantFinishImages");

            builder.HasKey(x => x.Id);
            builder.HasOne(pvfi => pvfi.ProductVariantFinish)
                    .WithMany(pvf => pvf.Images)
                    .HasForeignKey(pvfi => new { pvfi.ProductVariantId, pvfi.FinishId });
        }
    }
}
