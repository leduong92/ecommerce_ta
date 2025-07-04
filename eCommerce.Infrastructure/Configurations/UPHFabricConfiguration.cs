using eCommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eCommerce.Infrastructure.Configurations
{
    public class UPHFabricConfiguration : IEntityTypeConfiguration<UPHFabric>
    {
        public void Configure(EntityTypeBuilder<UPHFabric> builder)
        {
            builder.ToTable("UPHFabrics");

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).UseIdentityColumn();
            builder.Property(e => e.Fabric).HasMaxLength(64);
            builder.Property(e => e.Application).HasMaxLength(255);
            builder.Property(e => e.Category).HasMaxLength(20);
            builder.Property(e => e.CategoryTrim).HasMaxLength(50);
            builder.Property(e => e.CleaningCode).HasMaxLength(255);
            builder.Property(e => e.Color).HasMaxLength(255);
            builder.Property(e => e.ColorCode).HasMaxLength(32);
            builder.Property(e => e.Content1).HasMaxLength(255);
            builder.Property(e => e.Content2).HasMaxLength(255);
            builder.Property(e => e.Content3).HasMaxLength(255);
            builder.Property(e => e.Content4).HasMaxLength(255);
            builder.Property(e => e.Content5).HasMaxLength(255);
            builder.Property(e => e.Content6).HasMaxLength(255);
            builder.Property(e => e.Durability).HasMaxLength(255);
            builder.Property(e => e.Enable).HasDefaultValue(true);
            builder.Property(e => e.GradeVn).HasMaxLength(12);
            builder.Property(e => e.GradeTrim).HasMaxLength(10);
            builder.Property(e => e.Hrepeat).HasMaxLength(128);
            builder.Property(e => e.Vrepeat).HasMaxLength(128);
            builder.Property(e => e.ImageUrl);
            builder.Property(e => e.Name).HasMaxLength(64);
            builder.Property(e => e.Pattern).HasMaxLength(128);
            builder.Property(e => e.PatternCode).HasMaxLength(64);
            builder.Property(e => e.QtyOnHand).HasColumnType("decimal(18, 2)");
            builder.Property(e => e.Rubs).HasMaxLength(50);
            builder.Property(e => e.Sampled).HasMaxLength(255);
            builder.Property(e => e.Um).HasMaxLength(10);
            builder.Property(e => e.Width).HasMaxLength(255);
            builder.Property(x => x.IsActive).HasDefaultValue(true);
        }
    }
}
