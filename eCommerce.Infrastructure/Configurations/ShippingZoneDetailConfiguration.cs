using eCommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace eCommerce.Infrastructure.Configurations
{
    public class ShippingZoneDetailConfiguration : IEntityTypeConfiguration<ShippingZoneDetail>
    {
        public void Configure(EntityTypeBuilder<ShippingZoneDetail> builder)
        {
            builder.ToTable("ShippingZoneDetails");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).UseIdentityColumn();
            builder.Property(x => x.Value).HasMaxLength(64);
            builder.Property(x => x.Description).HasMaxLength(256);
            builder.HasOne(szt => szt.ShippingZone).WithMany(sz => sz.ShippingZoneDetails).HasForeignKey(szt => szt.ShippingZoneId);
            builder.HasIndex(szt => new { szt.DetailType, szt.Value, szt.ShippingZoneId });
                    

        }
    }
}
