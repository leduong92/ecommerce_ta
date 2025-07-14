using eCommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Application.Dtos
{
    public class ProductShippingProfileDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; // e.g., "Small Chair (Parcel)", "Dining Table (Pallet)", "Sofa (Freight)"
        public string? Description { get; set; }
        public bool IsBulky { get; set; } // Cồng kềnh
        public bool RequiresPallet { get; set; } = false; // Yêu cầu vận chuyển trên pallet
        public bool RequiresSpecialEquipment { get; set; } = false; // Cần xe nâng, cẩu...
        public double DefaultDimensionalFactor { get; set; } = 5000; // Can override category default
    }
}
