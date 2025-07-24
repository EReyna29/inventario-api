using InventarioAPI.Modelos;
using System.Linq.Expressions;

namespace InventarioAPI.Servicio
{
    public interface IPedidoDetalleService
    {
        public Task<List<PedidoDetalle>> GetAllItems();

        public Task<PedidoDetalle> CreateItem(PedidoDetalle articulo);

        public Task<PedidoDetalle> Update(PedidoDetalle articulo);

        public Task<List<PedidoDetalle>> GetItems(Expression<Func<PedidoDetalle, bool>> func);

        public Task<PedidoDetalle> GetItem(Expression<Func<PedidoDetalle, bool>> func);
    }
}
