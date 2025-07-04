using eCommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eCommerce.Infrastructure.Configurations
{
    public class ProductImageConfiguration : IEntityTypeConfiguration<ProductImage>
    {
        public void Configure(EntityTypeBuilder<ProductImage> builder)
        {
            builder.ToTable("ProductImages");
            builder.HasKey(p => p.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.ImageUrl).HasMaxLength(1024);
            builder.Property(x => x.IsPrimary).HasDefaultValue(false);

            builder.HasOne(i => i.ProductVariant).WithMany(v => v.ProductImages).HasForeignKey(i => i.ProductVariantId);
        }
    }
}
