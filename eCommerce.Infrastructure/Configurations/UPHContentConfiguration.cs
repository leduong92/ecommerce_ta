using eCommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eCommerce.Infrastructure.Configurations;
public class UPHContentConfiguration : IEntityTypeConfiguration<UPHContent>
{
    public void Configure(EntityTypeBuilder<UPHContent> builder)
    {
        builder.ToTable("UPHContents");
        builder.HasKey(x => x.Id);
        builder.Property(p => p.Id).UseIdentityColumn();
        builder.HasIndex(x => x.IsActive).IsUnique()
            .IncludeProperties(x => new
            {
                x.Name,
                x.Code
            });
        builder.Property(e => e.Code).HasMaxLength(48);
        builder.Property(e => e.Name).HasMaxLength(48);
    }
}