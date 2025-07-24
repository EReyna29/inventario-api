using InventarioAPI.Modelos;
using InventarioAPI.Repository;
using System.Linq.Expressions;

namespace InventarioAPI.Servicio
{
    public class ArticuloService (IGenericRepository<Articulo> repository) : IArticuloService
    {

        public async Task<List<Articulo>> GetAllItems()
        {
            return await repository.GetAll();
        }

        public async Task<Articulo> CreateItem(Articulo articulo)
        {
            return await repository.Add(articulo);
        }

        public async Task<Articulo> Update(Articulo articulo)
        {
            return await repository.Update(articulo);
        }

        public async Task<List<Articulo>> GetItems(Expression<Func<Articulo,bool>> func)
        {
            return await repository.GetValues(func);
        }

        public async Task<Articulo> GetItem(Expression<Func<Articulo, bool>> func)
        {
            return await repository.GetOne(func);
        }

    }
}
