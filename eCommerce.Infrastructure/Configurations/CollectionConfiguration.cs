

using eCommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eCommerce.Infrastructure.Configurations
{
    public class CollectionConfiguration : IEntityTypeConfiguration<Collection>
    {
        public void Configure(EntityTypeBuilder<Collection> builder)
        {
            builder.ToTable("Collections");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).UseIdentityColumn();
            builder.HasIndex(x => new { x.Slug, x.IsActive}).IsUnique()
                .IncludeProperties(x => new
                {
                    x.Name,
                    x.Description,
                    x.SortOrder,
                    x.MetaKeyword,
                    x.MetaDescription,
                    x.IsDescription,
                    x.IsLogo,
                    x.IsCarousel,
                    x.LifeStyleId
                });
            builder.HasIndex(x => x.IsActive);
            builder.Property(x => x.Name).HasMaxLength(64);
            builder.Property(x => x.Slug).HasMaxLength(128);
            builder.Property(x => x.Description).HasColumnType("nvarchar(max)");
            builder.Property(x => x.MetaKeyword).HasMaxLength(256);
            builder.Property(x => x.MetaDescription).HasMaxLength(512);
            builder.Property(x => x.IsActive).HasDefaultValue(true);
            builder.Property(x => x.IsDescription).HasDefaultValue(false);
            builder.Property(x => x.IsLogo).HasDefaultValue(false);
            builder.Property(x => x.IsCarousel).HasDefaultValue(false);
            builder.Property(x => x.LifeStyleId).HasDefaultValue(0);
        }
    }
}
