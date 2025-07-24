using InventarioAPI.Modelos;
using InventarioAPI.Repository;
using System.Linq.Expressions;

namespace InventarioAPI.Servicio
{
    public class PedidoDetalleService(IGenericRepository<PedidoDetalle> repository) : IPedidoDetalleService
    {
        public async Task<List<PedidoDetalle>> GetAllItems()
        {
            return await repository.GetAll();
        }

        public async Task<PedidoDetalle> CreateItem(PedidoDetalle articulo)
        {
            return await repository.Add(articulo);
        }

        public async Task<PedidoDetalle> Update(PedidoDetalle articulo)
        {
            return await repository.Update(articulo);
        }

        public async Task<List<PedidoDetalle>> GetItems(Expression<Func<PedidoDetalle, bool>> func)
        {
            return await repository.GetValues(func);
        }

        public async Task<PedidoDetalle> GetItem(Expression<Func<PedidoDetalle, bool>> func)
        {
            return await repository.GetOne(func);
        }
    }
}
