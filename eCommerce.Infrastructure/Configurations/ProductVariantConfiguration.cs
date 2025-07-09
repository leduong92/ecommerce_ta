using eCommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eCommerce.Infrastructure.Configurations
{
    public class ProductVariantConfiguration : IEntityTypeConfiguration<ProductVariant>
    {
        public void Configure(EntityTypeBuilder<ProductVariant> builder)
        {
            builder.ToTable("ProductVariants");
            builder.HasKey(p => p.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.PriceAdjustment).HasDefaultValue(0m).HasColumnType("decimal(18,2)");
            builder.Property(x => x.Sku).HasMaxLength(64);

            builder.HasOne(v => v.Product).WithMany(p => p.Variants).HasForeignKey(v => v.ProductId);

        }
    }
}
