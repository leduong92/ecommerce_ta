﻿using eCommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Application.Dtos
{
    public class ProductListDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public string Sku { get; set; } = string.Empty;
        public bool IsUpholstered { get; set; }
        public decimal? Price { get; set; }
        public string? Currency { get; set; }
        public decimal WeightKg { get; set; }
        public decimal LengthCm { get; set; }
        public decimal WidthCm { get; set; }
        public decimal HeightCm { get; set; }
        public string? DefaultImageUrl { get; set; }
        public int? EstimatedAvailableStock { get; set; } // Quantity available in the nearest warehouse
    }
    public class ProductDetailDto : ProductListDto
    {
        public string? Description { get; set; }
        public string? FulfillingWarehouseName { get; set; }
        public string? FulfillingWarehouseAddress { get; set; }
        public VariantDto SelectedVariant { get; set; } = null!;
        public List<OptionDto> ColorOptions { get; set; } = [];
        public List<OptionDto> SizeOptions { get; set; } = [];
        public List<FabricDto> FabricOptions { get; set; } = new();
        public List<FinishDto> FinishOptions { get; set; } = new();
        public ICollection<InventoryItemDto> InventoryItems { get; set; } = new List<InventoryItemDto>();
    }
    public class VariantDto
    {
        public int Id { get; set; }
        public string Sku { get; set; } = string.Empty;
        public decimal PriceAdjustment { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        public List<ProductImageDto> Images { get; set; }
    }
    public class OptionDto
    {
        public int ValueId { get; set; }
        public string Value { get; set; } = string.Empty;
        public List<int> VariantIds { get; set; } = [];
        public bool IsSelected { get; set; }
        public bool IsAvailable { get; set; } = true; 
    }

}
