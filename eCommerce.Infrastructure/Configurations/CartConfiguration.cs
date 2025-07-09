
using eCommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.Infrastructure.Configurations;

public class CartConfiguration : IEntityTypeConfiguration<Cart>
{
    public void Configure(EntityTypeBuilder<Cart> builder)
    {
        builder.ToTable("Carts");
        builder.HasKey(x => x.Id);
        builder.Property(e => e.Id).UseIdentityColumn();

        builder.Property(e => e.AnonymousId).HasMaxLength(36);

        builder.HasMany(sc => sc.CartItems).WithOne(ci => ci.Cart).HasForeignKey(sc => sc.CartId).OnDelete(DeleteBehavior.Cascade); // Delete cart items if cart is deleted

    }
}
