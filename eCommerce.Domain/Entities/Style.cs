﻿using System.ComponentModel.DataAnnotations;

namespace eCommerce.Domain.Entities
{
    public class Style: BaseEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string Slug { get; set; } = string.Empty;
        public string? Description { get; set; }
        public int SortOrder { get; set; }
        public string? ImageUrl { get; set; }
        public string? MetaKeyword { get; set; }
        public string? MetaDescription { get; set; }
    }
}
