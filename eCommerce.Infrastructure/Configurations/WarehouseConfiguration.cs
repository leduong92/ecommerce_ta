using eCommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eCommerce.Infrastructure.Configurations
{
    public class WarehouseConfiguration : IEntityTypeConfiguration<Warehouse>
    {
        public void Configure(EntityTypeBuilder<Warehouse> builder)
        {
            builder.ToTable("Warehouses");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).UseIdentityColumn();
            builder.Property(x => x.Name).HasMaxLength(64);
            builder.Property(x => x.Address1).HasMaxLength(512);
            builder.Property(x => x.Address2).HasMaxLength(512);
            builder.Property(x => x.City).HasMaxLength(64);
            builder.Property(x => x.StateProvince).HasMaxLength(64);
            builder.Property(x => x.ZipCode).HasMaxLength(24);
            builder.Property(x => x.CountryCode).HasMaxLength(8);
            builder.Property(x => x.ContactPhone).HasMaxLength(15);
            builder.Property(x => x.Email).HasMaxLength(128);
            builder.Property(x => x.Description).HasMaxLength(512);
            builder.Property(x => x.CountryCode).HasMaxLength(8);
            builder.Property(x => x.Latitude).HasDefaultValue(0);
            builder.Property(x => x.Longitude).HasDefaultValue(0);
            builder.Property(x => x.IsActive).HasDefaultValue(true);

            builder.HasOne(w => w.ShippingZone).WithMany().HasForeignKey(w => w.ShippingZoneId).IsRequired(false);
            builder.HasOne(w => w.Region)
                     .WithMany(r => r.Warehouses)
                     .HasForeignKey(w => w.RegionId)
                     .IsRequired(false); // A warehouse might not strictly need a RegionId directly if ShippingZone covers it

            builder.HasIndex(w => new { w.CountryCode, w.StateProvince, w.ZipCode }); // For quick lookup
            builder.HasIndex(w => new { w.Latitude, w.Longitude }); // For spatial queries
        }
    }
}
