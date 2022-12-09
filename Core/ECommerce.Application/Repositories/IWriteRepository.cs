namespace ECommerce.Application.Repositories
{
    public interface IWriteRepository<T> : IRepository<T> where T : class
    {
        Task<bool> AddAsync(T? entity);
        Task<bool> AddRangeAsync(List<T> datas);
        bool Remove(T? entity);
        bool RemoveRange(List<T> datas);
        Task<bool> RemoveAsync(string id);
        bool Update(T? entity);
        Task<int> SaveAsync();
    }
}
