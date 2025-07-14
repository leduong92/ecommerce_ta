using eCommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Application.Dtos
{
    public class InventoryItemDto
    {
        public int WarehouseId { get; set; }
        public int Stock { get; set; }
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int QuantityOnHand { get; set; } // Số lượng hiện có
        public int QuantityReserved { get; set; } // Số lượng đã đặt nhưng chưa xuất kho
        public int MinimumStockLevel { get; set; } // Ngưỡng tồn kho tối thiểu để cảnh báo
        public int AvailableQuantity => QuantityOnHand - QuantityReserved;
    }
}
