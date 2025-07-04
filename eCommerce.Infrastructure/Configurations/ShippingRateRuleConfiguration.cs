using eCommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace eCommerce.Infrastructure.Configurations
{
    public class ShippingRateRuleConfiguration : IEntityTypeConfiguration<ShippingRateRule>
    {
        public void Configure(EntityTypeBuilder<ShippingRateRule> builder)
        {
            builder.ToTable("ShippingRateRules");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).UseIdentityColumn();

            builder.Property(srr => srr.RuleName).HasMaxLength(128);
            builder.Property(srr => srr.Description).HasMaxLength(256);

            builder.Property(srr => srr.BaseRate).HasColumnType("decimal(18,2)");
            builder.Property(srr => srr.RatePerKg).HasColumnType("decimal(18,2)");
            builder.Property(srr => srr.RatePerCbm).HasColumnType("decimal(18,2)");
            builder.Property(srr => srr.RatePerItem).HasColumnType("decimal(18,2)");
            builder.Property(srr => srr.MinApplicableWeightKg).HasColumnType("decimal(18,2)");
            builder.Property(srr => srr.MaxApplicableWeightKg).HasColumnType("decimal(18,2)");
            builder.Property(srr => srr.MinApplicableCbm).HasColumnType("decimal(18,2)");
            builder.Property(srr => srr.MaxApplicableCbm).HasColumnType("decimal(18,2)");
            builder.Property(srr => srr.MinOrderValue).HasColumnType("decimal(18,2)");
            builder.Property(srr => srr.MaxOrderValue).HasColumnType("decimal(18,2)");
            builder.Property(srr => srr.FreeShippingMinOrderValue).HasColumnType("decimal(18,2)");
            builder.Property(srr => srr.FlatSurcharge).HasColumnType("decimal(18,2)");
            builder.Property(srr => srr.PercentageSurcharge).HasColumnType("decimal(18,2)");
            builder.Property(srr => srr.SurchargePerFloor).HasColumnType("decimal(18,2)");
            builder.Property(srr => srr.RuralAreaSurchargeAmount).HasColumnType("decimal(18,2)");
            builder.Property(srr => srr.MaxOrderWeightOrVolume).HasColumnType("decimal(18,2)");
            builder.Property(srr => srr.MaxWeightKg).HasColumnType("decimal(18,2)");
            builder.Property(srr => srr.MinOrderWeightOrVolume).HasColumnType("decimal(18,2)");
            builder.Property(srr => srr.MinWeightKg).HasColumnType("decimal(18,2)");
            

            builder.Property(x => x.IsActive).HasDefaultValue(true);

            builder.HasOne(srr => srr.OriginShippingZone).WithMany(sz => sz.OriginRateRules).HasForeignKey(srr => srr.OriginShippingZoneId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(srr => srr.DestinationShippingZone).WithMany(sz => sz.DestinationRateRules).HasForeignKey(srr => srr.DestinationShippingZoneId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(srr => srr.ShippingServiceLevel).WithMany(sz => sz.ShippingRateRules).HasForeignKey(srr => srr.ShippingServiceLevelId);

            builder.HasOne(srr => srr.ProductShippingProfile).WithMany().HasForeignKey(srr => srr.ProductShippingProfileId).IsRequired(false);
            builder.HasOne(srr => srr.ProductCategory).WithMany().HasForeignKey(srr => srr.ProductCategoryId).IsRequired(false);
            builder.HasOne(srr => srr.GlobalShippingLane).WithMany().HasForeignKey(srr => srr.GlobalShippingLaneId).IsRequired(false);

            builder.HasIndex(srr => new
            {
                srr.OriginShippingZoneId,
                srr.DestinationShippingZoneId,
                srr.ShippingServiceLevelId,
                srr.ProductShippingProfileId,
                srr.IsActive
            });
        }
    }
}
