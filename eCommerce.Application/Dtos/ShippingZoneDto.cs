using eCommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Application.Dtos
{
    public class ShippingZoneDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; // e.g., "Contiguous US", "Europe Zone 1", "Vietnam Northern"
        public string Description { get; set; } = string.Empty;

        // Foreign Key to Region
        public int? RegionId { get; set; }
    }
}
