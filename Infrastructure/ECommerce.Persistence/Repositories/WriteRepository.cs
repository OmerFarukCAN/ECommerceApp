using ECommerce.Application.Repositories;
using ECommerce.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace ECommerce.Persistence.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : class
    {
        private readonly ECommerceDbContext _eCommerceDbContext;

        public WriteRepository(ECommerceDbContext eCommerceDbContext)
        {
            _eCommerceDbContext = eCommerceDbContext;
        }

        public DbSet<T> Table => _eCommerceDbContext.Set<T>();

        public async Task<bool> AddAsync(T? entity)
        {
            var entityEntry = await Table.AddAsync(entity ?? throw new ArgumentNullException(nameof(entity)));
            return entityEntry.State == EntityState.Added;
        }

        public async Task<bool> AddRangeAsync(List<T> datas)
        {
            await Table.AddRangeAsync(datas);
            return true;
        }

        public bool Remove(T? entity)
        {
            var entityEntry = Table.Remove(entity!);
            return entityEntry.State == EntityState.Deleted;
        }

        public bool RemoveRange(List<T> datas)
        {
            Table.RemoveRange(datas);
            return true;
        }

        public async Task<bool> RemoveAsync(string id)
        {
            T? entity = await Table.FindAsync(Guid.Parse(id));
            return Remove(entity);
        }

        public bool Update(T? entity)
        {
            var entityEntry = Table.Update(entity!);
            return entityEntry.State == EntityState.Modified;
        }
        public async Task<int> SaveAsync()
            => await _eCommerceDbContext.SaveChangesAsync();
    }
}
