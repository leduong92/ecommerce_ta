﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Application.Dtos
{
    public class RemoveFromCartRequest
    {
        public string? AnonymousId { get; set; }
        public int ProductId { get; set; }
    }
}
