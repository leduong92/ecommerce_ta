﻿using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerce.Domain.Entities
{
    public class CartItem
    {
        public int Id { get; set; }
        public int CartId { get; set; }
        public Cart Cart { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; } // Price at the time of adding to cart
        [NotMapped]
        public decimal TotalPrice => Quantity * UnitPrice;
    }
}
