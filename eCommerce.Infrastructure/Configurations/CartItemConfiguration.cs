
using eCommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.Infrastructure.Configurations;

public class CartItemConfiguration : IEntityTypeConfiguration<CartItem>
{
    public void Configure(EntityTypeBuilder<CartItem> builder)
    {
        builder.ToTable("CartItems");
        builder.HasKey(x => x.Id);
        builder.Property(e => e.Id).UseIdentityColumn();
        builder.Property(ci => ci.Currency).HasMaxLength(18);
        builder.Property(ci => ci.RegionCode).HasMaxLength(18);

        builder.HasOne(ci => ci.Product)
                .WithMany()
                .HasForeignKey(ci => ci.ProductId);

        builder.HasOne(c => c.ProductVariant)
                .WithMany()
                .HasForeignKey(c => c.ProductVariantId)
                .OnDelete(DeleteBehavior.Restrict); // hoặc DeleteBehavior.NoAction

        builder.Property(ci => ci.UnitPrice).HasColumnType("decimal(18,2)");
    }
}
