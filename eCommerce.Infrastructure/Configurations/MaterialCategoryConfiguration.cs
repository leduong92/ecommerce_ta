using eCommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace eCommerce.Infrastructure.Configurations
{
    public class MaterialCategoryConfiguration : IEntityTypeConfiguration<MaterialCategory>
    {
        public void Configure(EntityTypeBuilder<MaterialCategory> builder)
        {
            builder.ToTable("MaterialCategories");
            builder.HasKey(p => p.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name).HasMaxLength(64);
            builder.Property(x => x.IsActive).HasDefaultValue(true);
        }
    }
}
