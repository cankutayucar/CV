using CankutayUcarCV.Business.Abstract;
using CankutayUcarCV.DataAccess.Abstract;
using CankutayUcarCV.Entities.Abstract;

namespace CankutayUcarCV.Business.Concrete
{
    public class Service<T> : IService<T>
    where T: class, IBase, new()
    {
        private readonly IRepository<T> _repository;
        public Service(IRepository<T> repository)
        {
            _repository = repository;
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            var result =await _repository.GetAllAsync();
            return result.ToList();
        }

        public async Task<int> GetCountAsync()
        {
            return await _repository.GetCountAsync();
        }

        public async Task<int> InsertAsync(T entity)
        {
            return await _repository.InsertAsync(entity);
        }

        public async Task<bool> UpdateAsync(T entity)
        {
            return await  _repository.UpdateAsync(entity);
        }

        public async Task<bool> DeleteAsync(T entity)
        {
            return await _repository.DeleteAsync(entity);
        }
    }
}
