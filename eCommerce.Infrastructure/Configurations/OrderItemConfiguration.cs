using eCommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eCommerce.Infrastructure.Configurations
{
    public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.ToTable("OrderItems");
            builder.HasKey(p => p.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.UnitPrice).HasColumnType("decimal(18,2)");

            builder.HasOne(oi => oi.Product).WithMany().HasForeignKey(oi => oi.ProductId);
            builder.Property(oi => oi.UnitPrice).HasColumnType("decimal(18,2)");
            builder.Property(oi => oi.TotalPrice).HasColumnType("decimal(18,2)");

        }
    }
}
