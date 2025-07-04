using eCommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eCommerce.Infrastructure.Configurations
{
    public class RoomConfiguration : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            builder.ToTable("Rooms");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).UseIdentityColumn();
            builder.HasIndex(x => new { x.Slug, x.IsActive }).IsUnique()
                .IncludeProperties(x => new 
                {
                    x.Name,
                    x.Description,
                    x.ImageUrl,
                    x.SortOrder,
                    x.MetaDescription,
                    x.MetaKeyword,
                });
            builder.Property(x => x.Name).HasMaxLength(64);
            builder.Property(x => x.SortOrder).HasDefaultValue(0);
            builder.Property(x => x.Slug).HasMaxLength(128);
            builder.Property(x => x.ImageUrl).HasMaxLength(1024);
            builder.Property(x => x.Description).HasColumnType("nvarchar(max)");
            builder.Property(x => x.MetaKeyword).HasMaxLength(256);
            builder.Property(x => x.MetaDescription).HasMaxLength(512);
            builder.Property(x => x.IsActive).HasDefaultValue(true);

            builder.HasMany(e => e.ProductTypes)
               .WithOne()
               .HasForeignKey(e => e.RoomId)
               .IsRequired();
        }
    }
}
