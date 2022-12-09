using ECommerce.Application.Repositories;
using ECommerce.Persistence.Contexts;

namespace ECommerce.Persistence.Repositories.Product
{
    public class ProductReadRepository : ReadRepository<Ecommerce.Domain.Product>, IProductReadRepository
    {
        public ProductReadRepository(ECommerceDbContext eCommerceDbContext) : base(eCommerceDbContext)
        {
        }
    }
}
