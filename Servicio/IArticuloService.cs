using InventarioAPI.Modelos;
using System.Linq.Expressions;

namespace InventarioAPI.Servicio
{
    public interface IArticuloService
    {
        public Task<List<Articulo>> GetAllItems();

        public Task<Articulo> CreateItem(Articulo articulo);

        public Task<Articulo> Update(Articulo articulo);

        public Task<List<Articulo>> GetItems(Expression<Func<Articulo, bool>> func);

        public Task<Articulo> GetItem(Expression<Func<Articulo, bool>> func);
    }
}
