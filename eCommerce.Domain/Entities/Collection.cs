﻿using System.ComponentModel.DataAnnotations;

namespace eCommerce.Domain.Entities
{
    public class Collection : BaseEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string Slug { get; set; }
        public string? Description { get; set; }
        public int SortOrder { get; set; }
        public string? MetaKeyword { get; set; }
        public string? MetaDescription { get; set; }
        public bool IsDescription { get; set; }
        public bool IsLogo { get; set; }
        public bool IsCarousel { get; set; }
        public int LifeStyleId { get; set; }
    }
}
