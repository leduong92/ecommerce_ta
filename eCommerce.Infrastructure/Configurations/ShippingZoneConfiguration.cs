using eCommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace eCommerce.Infrastructure.Configurations
{
    public class ShippingZoneConfiguration : IEntityTypeConfiguration<ShippingZone>
    {
        public void Configure(EntityTypeBuilder<ShippingZone> builder)
        {
            builder.ToTable("ShippingZones");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).UseIdentityColumn();
            builder.Property(x => x.Name).HasMaxLength(64);

            builder.Property(x => x.Description).HasMaxLength(256);
            builder.HasOne(sz => sz.Region).WithMany(r => r.ShippingZones).HasForeignKey(sz => sz.RegionId).IsRequired(false);

        }
    }
}
