using CankutayUcarCV.Entities.Abstract;

namespace CankutayUcarCV.DataAccess.Abstract
{
    public interface IRepository<T>
    where T : class, IBase, new()
    {
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<int> GetCountAsync();
        Task<int> InsertAsync(T entity);
        Task<bool> UpdateAsync(T entity);
        Task<bool> DeleteAsync(T entity);
    }
}
