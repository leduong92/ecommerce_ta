using eCommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace eCommerce.Infrastructure.Configurations
{
    public class GlobalShippingLaneConfiguration : IEntityTypeConfiguration<GlobalShippingLane>
    {
        public void Configure(EntityTypeBuilder<GlobalShippingLane> builder)
        {
            builder.ToTable("GlobalShippingLanes");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).UseIdentityColumn();
            builder.Property(x => x.Name).HasMaxLength(128);
            builder.Property(x => x.PrimaryCarrierPartner).HasMaxLength(128);
            builder.Property(x => x.TransitMode).HasMaxLength(64);

            builder.HasOne(gsl => gsl.OriginShippingZone).WithMany().HasForeignKey(gsl => gsl.OriginShippingZoneId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(gsl => gsl.DestinationShippingZone).WithMany().HasForeignKey(gsl => gsl.DestinationShippingZoneId).OnDelete(DeleteBehavior.Restrict);

        }
    }
}
