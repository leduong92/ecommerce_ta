using eCommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eCommerce.Infrastructure.Configurations
{
    public class ProductFabricConfiguration : IEntityTypeConfiguration<ProductFabric>
    {
        public void Configure(EntityTypeBuilder<ProductFabric> builder)
        {
            builder.ToTable("ProductFabrics");
            builder.HasKey(p => p.Id);
            builder.HasIndex(x => new { x.FabricCode, x.IsActive });
            builder.Property(p => p.Id).UseIdentityColumn();
            builder.Property(x => x.FabricCode).HasMaxLength(24);
            builder.Property(x => x.Desccription).HasMaxLength(128);
            builder.Property(x => x.IsActive).HasDefaultValue(true);
        }
    }
}
