using eCommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eCommerce.Infrastructure.Configurations;
public class UPHColorConfiguration : IEntityTypeConfiguration<UPHColor>
{
    public void Configure(EntityTypeBuilder<UPHColor> builder)
    {
        builder.ToTable("UPHColours");
        builder.HasKey(x => x.Id);
        builder.Property(p => p.Id).UseIdentityColumn();
        builder.HasIndex(x => x.IsActive).IsUnique()
            .IncludeProperties(x => new
            {
                x.Colour,
                x.CodeHex,
                x.Code
            });
        builder.Property(e => e.Code).HasMaxLength(32);
        builder.Property(e => e.CodeHex).HasMaxLength(32);
        builder.Property(e => e.Colour).IsRequired().HasMaxLength(128);
    }
}