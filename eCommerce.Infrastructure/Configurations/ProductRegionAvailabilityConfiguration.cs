using eCommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eCommerce.Infrastructure.Configurations
{
    public class ProductRegionAvailabilityConfiguration : IEntityTypeConfiguration<ProductRegionAvailability>
    {
        public void Configure(EntityTypeBuilder<ProductRegionAvailability> builder)
        {
            builder.ToTable("ProductRegionAvailabilitys");
            builder.HasKey(p => p.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.HasOne(pra => pra.Product)
                      .WithMany(p => p.RegionAvailabilities)
                      .HasForeignKey(pra => pra.ProductId)
                      .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(pra => pra.Region)
                  .WithMany() // ProductRegionAvailability is not a primary collection for Region
                  .HasForeignKey(pra => pra.RegionId)
                  .OnDelete(DeleteBehavior.Restrict);

            builder.HasIndex(pra => new { pra.ProductId, pra.RegionId }).IsUnique();
        }
    }
}
