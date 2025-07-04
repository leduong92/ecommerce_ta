
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

        builder.HasOne(ci => ci.Product).WithMany().HasForeignKey(ci => ci.ProductId);

        builder.Property(ci => ci.UnitPrice).HasColumnType("decimal(18,2)");
    }
}
