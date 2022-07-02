using System.Data;
using CankutayUcarCV.DataAccess.Abstract;
using CankutayUcarCV.Entities.Abstract;
using Dapper.Contrib.Extensions;

namespace CankutayUcarCV.DataAccess.Concrete
{
    public class Repository<T> : IRepository<T>
    where T : class, IBase, new()
    {
        private readonly IDbConnection _dbConnection;

        public Repository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbConnection.GetAsync<T>(id);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return (await _dbConnection.GetAllAsync<T>()).ToList();
        }

        public async Task<int> GetCountAsync()
        {
            return (await _dbConnection.GetAllAsync<T>()).ToList().Count;
        }

        public async Task<int> InsertAsync(T entity)
        {
            return await _dbConnection.InsertAsync<T>(entity);
        }

        public async Task<bool> UpdateAsync(T entity)
        {
            return await _dbConnection.UpdateAsync<T>(entity);
        }

        public async Task<bool> DeleteAsync(T entity)
        {
            return await _dbConnection.DeleteAsync<T>(entity);
        }
    }
}
