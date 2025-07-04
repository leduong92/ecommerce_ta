using eCommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eCommerce.Infrastructure.Configurations
{
    public class CollectionImageConfiguration : IEntityTypeConfiguration<CollectionImage>
    {
        public void Configure(EntityTypeBuilder<CollectionImage> builder)
        {
            builder.ToTable("CollectionImages");
            builder.HasKey(p => p.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.ImageUrl).HasMaxLength(1024);
            builder.Property(x => x.ImageType).HasDefaultValue(0);
            builder.Property(x => x.SortOrder).HasDefaultValue(0);
        }
    }
}
