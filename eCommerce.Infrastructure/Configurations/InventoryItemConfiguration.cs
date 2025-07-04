using eCommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eCommerce.Infrastructure.Configurations
{
    public class InventoryItemConfiguration : IEntityTypeConfiguration<InventoryItem>
    {
        public void Configure(EntityTypeBuilder<InventoryItem> builder)
        {
            builder.ToTable("InventoryItems");
            builder.HasKey(p => p.Id);

            // OPTIONAL: Explicitly configure RowVersion, though [Timestamp] attribute usually suffices
            builder.Property(ii => ii.RowVersion).IsRowVersion(); // Or .IsConcurrencyToken();

            builder.HasOne(ii => ii.Product).WithMany().HasForeignKey(ii => ii.ProductId);
            builder.HasOne(ii => ii.Warehouse).WithMany(w => w.InventoryItems).HasForeignKey(ii => ii.WarehouseId);

            builder.HasIndex(ii => new { ii.ProductId, ii.WarehouseId }).IsUnique();
        }
    }
}
