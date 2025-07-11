using eCommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eCommerce.Infrastructure.Configurations
{
    public class FinishConfiguration : IEntityTypeConfiguration<Finish>
    {
        public void Configure(EntityTypeBuilder<Finish> builder)
        {
            builder.ToTable("Finishs");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).UseIdentityColumn();
            builder.Property(x => x.Name).HasMaxLength(64).IsUnicode(true);
            builder.Property(x => x.Code).HasMaxLength(12);
            builder.Property(x => x.IsActive).HasDefaultValue(true);
        }
    }
}
