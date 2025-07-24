using System.Linq.Expressions;

namespace InventarioAPI.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        public Task<T> Add(T model);

        public Task<List<T>> GetAll();

        public Task<T> GetOne(Expression<Func<T,bool>> func);

        public Task<List<T>> GetValues(Expression<Func<T, bool>> func);

        public Task<T> Update(T model);

        public Task<int> UpdateSome(List<T> model);

        public Task<int> Delete(T model);
    }
}
