using ECommerce.Application.Repositories;
using ECommerce.Persistence.Contexts;

namespace ECommerce.Persistence.Repositories.Product
{
    public class ProductWriteRepository : WriteRepository<Ecommerce.Domain.Product>, IProductWriteRepository
    {
        public ProductWriteRepository(ECommerceDbContext eCommerceDbContext) : base(eCommerceDbContext)
        {
        }
    }
}
