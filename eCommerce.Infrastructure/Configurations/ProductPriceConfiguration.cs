using eCommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;


namespace eCommerce.Infrastructure.Configurations
{
    public class ProductPriceConfiguration : IEntityTypeConfiguration<ProductPrice>
    {
        public void Configure(EntityTypeBuilder<ProductPrice> builder)
        {
            builder.ToTable("ProductPrices");
            builder.Property(x => x.Price).HasDefaultValue(0m).HasColumnType("decimal(18,2)");
            builder.Property(x => x.Currency).HasMaxLength(24);

            builder.HasOne(pp => pp.Product).WithMany(p => p.Prices).HasForeignKey(pp => pp.ProductId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(pp => pp.Region).WithMany().HasForeignKey(pp => pp.RegionId).OnDelete(DeleteBehavior.Restrict);

            builder.HasIndex(pp => new { pp.ProductId, pp.RegionId, pp.EffectiveDate }).IsUnique();
        }
    }
}
