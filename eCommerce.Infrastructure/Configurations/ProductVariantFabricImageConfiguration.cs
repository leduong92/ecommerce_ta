using eCommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace eCommerce.Infrastructure.Configurations
{
    public class ProductVariantFabricImageConfiguration : IEntityTypeConfiguration<ProductVariantFabricImage>
    {
        public void Configure(EntityTypeBuilder<ProductVariantFabricImage> builder)
        {
            builder.ToTable("ProductVariantFabricImages");

            builder.HasKey(x => x.Id);
            builder.HasOne(pvfi => pvfi.ProductVariantFabric)
                    .WithMany(pvf => pvf.Images)
                    .HasForeignKey(pvfi => new { pvfi.ProductVariantId, pvfi.FabricId });
        }
    }
}
