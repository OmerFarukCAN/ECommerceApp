﻿using Ecommerce.Domain.Common;

namespace Ecommerce.Domain
{
    public class Order : BaseEntity
    {
        public Guid CustomerId { get; set; }
        public string? Description { get; set; }
        public string? Address { get; set; }

        public ICollection<Product>? Products { get; set; } // n -- n relationship
        public Customer? Customer { get; set; }
    }
}
