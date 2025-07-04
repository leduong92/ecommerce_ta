//using eCommerce.Domain.Entities;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;

//namespace eCommerce.Infrastructure.Configurations
//{
//    public class DeliveryTypeConfiguration : IEntityTypeConfiguration<DeliveryType>
//    {
//        public void Configure(EntityTypeBuilder<DeliveryType> builder)
//        {
//            builder.ToTable("DeliveryTypes");
//            builder.HasKey(p => p.Id);
//            builder.Property(x => x.Id).UseIdentityColumn();
//            builder.Property(x => x.Name).HasMaxLength(32);
         
//        }
//    }
//}
