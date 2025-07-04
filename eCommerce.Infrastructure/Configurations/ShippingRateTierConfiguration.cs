using eCommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace eCommerce.Infrastructure.Configurations
{
    public class ShippingRateTierConfiguration : IEntityTypeConfiguration<ShippingRateTier>
    {
        public void Configure(EntityTypeBuilder<ShippingRateTier> builder)
        {
            builder.ToTable("ShippingRateTiers");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).UseIdentityColumn();
            builder.Property(p => p.TierUnit).HasMaxLength(12);

            builder.Property(srt => srt.MinValue).HasColumnType("decimal(18,2)");
            builder.Property(srt => srt.MaxValue).HasColumnType("decimal(18,2)");
            builder.Property(srt => srt.RatePerUnit).HasColumnType("decimal(18,2)");
            builder.Property(srt => srt.FixedTierCost).HasColumnType("decimal(18,2)");

            builder.HasOne(srt => srt.ShippingRateRule)
                      .WithMany(srr => srr.ShippingRateTiers)
                      .HasForeignKey(srt => srt.ShippingRateRuleId)
                      .OnDelete(DeleteBehavior.Cascade); // If rule is deleted, tiers are deleted
        }
    }
}
