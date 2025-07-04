

using eCommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eCommerce.Infrastructure.Configurations;
public class UPHPatternConfiguration : IEntityTypeConfiguration<UPHPattern>
{
    public void Configure(EntityTypeBuilder<UPHPattern> builder)
    {
        builder.ToTable("UPHPatterns");
        builder.HasKey(x => x.Id);
        builder.Property(p => p.Id).UseIdentityColumn();
        builder.HasIndex(x => x.IsActive).IsUnique()
            .IncludeProperties(x => new
            {
                x.Pattern,
                x.Patterncode,
            });
        builder.Property(e => e.Pattern).HasMaxLength(64);
        builder.Property(e => e.Patterncode).HasMaxLength(12);
    }
}