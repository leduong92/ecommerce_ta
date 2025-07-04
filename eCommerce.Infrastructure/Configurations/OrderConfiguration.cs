using eCommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eCommerce.Infrastructure.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders");
            builder.HasKey(p => p.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Status).HasMaxLength(18);
            builder.Property(x => x.TotalAmount).HasColumnType("decimal(18,2)");

            builder.Property(o => o.ShippingFirstName).HasMaxLength(32);
            builder.Property(o => o.ShippingLastName).HasMaxLength(64);
            builder.Property(o => o.ShippingAddress1).HasMaxLength(512);
            builder.Property(o => o.ShippingAddress2).HasMaxLength(512);
            builder.Property(o => o.ShippingCity).HasMaxLength(64);
            builder.Property(o => o.ShippingStateProvince).HasMaxLength(64);
            builder.Property(o => o.ShippingZipCode).HasMaxLength(12);
            builder.Property(o => o.ShippingCountryCode).HasMaxLength(24);
            builder.Property(o => o.ShippingPhoneNumber).HasMaxLength(15);

            builder.Property(o => o.ChosenShippingServiceLevelName).HasMaxLength(64);
            builder.Property(o => o.ChosenShippingDeliveryType).HasMaxLength(64);
            builder.Property(o => o.ChosenShippingOriginWarehouseName).HasMaxLength(128);
            builder.Property(o => o.ChosenShippingRouteDescription).HasMaxLength(512);

            builder.Property(o => o.Subtotal).HasColumnType("decimal(18,2)");
            builder.Property(o => o.ShippingCost).HasColumnType("decimal(18,2)");
            builder.Property(o => o.TotalAmount).HasColumnType("decimal(18,2)");

            builder.Property(o => o.ShippingLatitude).HasColumnType("float");
            builder.Property(o => o.ShippingLongitude).HasColumnType("float");

            builder.HasMany(oi => oi.OrderItems).WithOne(o => o.Order).HasForeignKey(oi => oi.OrderId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(o => o.FulfillingWarehouse).WithMany().HasForeignKey(o => o.FulfillingWarehouseId)
                .IsRequired(false);  // Warehouse can be null if order not yet fulfilled or cancelled

        }
    }
}
