

using eCommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.Infrastructure.Configurations;

public class CareConfiguration : IEntityTypeConfiguration<Care>
{
    public void Configure(EntityTypeBuilder<Care> builder)
    {
        builder.ToTable("Cares");
        builder.HasKey(x => x.Id);
        builder.Property(e => e.Id).UseIdentityColumn();
        builder.Property(e => e.ContentBody).HasColumnType("nvarchar(max)");
        builder.Property(e => e.ContentImageS7).HasMaxLength(50).IsUnicode(false);
        builder.Property(e => e.ContentTitle).HasMaxLength(50)
            .IsUnicode(false);
        builder.Property(e => e.DisplayName).HasMaxLength(64);
        builder.Property(e => e.Name)
            .HasMaxLength(50)
            .IsUnicode(false);
        builder.Property(e => e.IamgeUrl).HasMaxLength(1024);

    }
}
