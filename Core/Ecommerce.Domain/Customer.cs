using Ecommerce.Domain.Common;

namespace Ecommerce.Domain
{
    public class Customer : BaseEntity
    {
        public string? CustomerName { get; set; }
        public ICollection<Order>? Orders { get; set; }
    }
}
