using Ecommerce.Domain.Common;

namespace Ecommerce.Domain
{
    public class Product : BaseEntity
    {
        public string? ProductName { get; set; }
        public int Stock { get; set; }
        public float Price { get; set; }
        public ICollection<Order>? Orders { get; set; } // n -- n relationship
    }
}
