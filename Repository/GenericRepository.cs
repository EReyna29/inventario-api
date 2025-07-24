using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace InventarioAPI.Repository
{
    public class GenericRepository<T>(InventarioContext context) : IGenericRepository<T> where T : class
    {
        public async Task<T> Add(T model)
        {
            var value = await context.Set<T>().AddAsync(model);
            await context.SaveChangesAsync();

            return value.Entity; 
        }

        public async Task<int> Delete(T model)
        {
            var value = await context.Set<T>().ExecuteDeleteAsync();
            await context.SaveChangesAsync();

            return value;
        }

        public async Task<List<T>> GetAll()
        {
            return await context.Set<T>().AsNoTracking().ToListAsync();
        }

        public async Task<T> GetOne(Expression<Func<T, bool>> func)
        {
            return (await context.Set<T>().AsNoTracking().FirstOrDefaultAsync(func))!;
        }

        public async Task<List<T>> GetValues(Expression<Func<T, bool>> func)
        {
            return (await context.Set<T>().AsNoTracking().Where(func).ToListAsync())!;
        }

        public async Task<T> Update(T model)
        {
            var newEntity = context.Set<T>().Update(model).Entity;
            await context.SaveChangesAsync();
            return newEntity;
        }

        public async Task<int> UpdateSome(List<T> model)
        {
            var added = 0;
            try
            {
                context.Set<T>().UpdateRange(model);
                added = await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return added;
        }
    }
}
