using eCommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eCommerce.Infrastructure.Configurations
{
    public class ProductShippingProfileConfiguration : IEntityTypeConfiguration<ProductShippingProfile>
    {
        public void Configure(EntityTypeBuilder<ProductShippingProfile> builder)
        {
            builder.ToTable("ProductShippingProfiles");
            builder.HasKey(p => p.Id);
        
            builder.Property(p => p.Id).UseIdentityColumn();
            builder.Property(x => x.Name).HasMaxLength(64);
            builder.Property(x => x.Description).HasMaxLength(128);
        }

    }
}
