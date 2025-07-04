using System.ComponentModel.DataAnnotations;

namespace eCommerce.Domain.Entities
{
    public class InventoryItem : BaseEntity
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;
        public int WarehouseId { get; set; }
        public Warehouse Warehouse { get; set; } = null!;

        public int QuantityOnHand { get; set; } // Số lượng hiện có
        public int QuantityReserved { get; set; } // Số lượng đã đặt nhưng chưa xuất kho
        public int MinimumStockLevel { get; set; } // Ngưỡng tồn kho tối thiểu để cảnh báo

        // NEW: Thuộc tính để xử lý Optimistic Concurrency
        [Timestamp] // Attribute này đánh dấu đây là một cột timestamp/rowversion
        public byte[] RowVersion { get; set; } = null!; // SQL Server sẽ tự động quản lý giá trị này

        // Calculated property for available quantity
        public int AvailableQuantity => QuantityOnHand - QuantityReserved;
        public DateTime LastUpdated { get; set; }
    }
}
