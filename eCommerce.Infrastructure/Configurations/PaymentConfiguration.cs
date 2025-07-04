using eCommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eCommerce.Infrastructure.Configurations
{
    public class PaymentConfiguration : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.ToTable("Payments");
            builder.HasKey(p => p.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.CurrencyCode).HasMaxLength(8);
            builder.Property(x => x.Status).HasMaxLength(18);
            builder.Property(x => x.PaymentMethod).HasMaxLength(18);
            builder.Property(x => x.Amount).HasColumnType("decimal(18,2)");
        }
    }
}
