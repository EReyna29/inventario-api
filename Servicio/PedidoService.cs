using InventarioAPI.Modelos;
using InventarioAPI.Repository;
using System.Linq.Expressions;

namespace InventarioAPI.Servicio
{
    public class PedidoService(IGenericRepository<Pedido> repository) : IPedidoService
    {
        public async Task<List<Pedido>> GetAllItems()
        {
            return await repository.GetAll();
        }

        public async Task<Pedido> CreateItem(Pedido articulo)
        {
            return await repository.Add(articulo);
        }

        public async Task<Pedido> Update(Pedido articulo)
        {
            return await repository.Update(articulo);
        }

        public async Task<List<Pedido>> GetItems(Expression<Func<Pedido, bool>> func)
        {
            return await repository.GetValues(func);
        }

        public async Task<Pedido> GetItem(Expression<Func<Pedido, bool>> func)
        {
            return await repository.GetOne(func);
        }
    }
}
