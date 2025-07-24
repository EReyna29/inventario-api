using InventarioAPI.Modelos;
using System.Linq.Expressions;

namespace InventarioAPI.Servicio
{
    public interface IPedidoService
    {
        public Task<List<Pedido>> GetAllItems();

        public Task<Pedido> CreateItem(Pedido articulo);

        public Task<Pedido> Update(Pedido articulo);

        public Task<List<Pedido>> GetItems(Expression<Func<Pedido, bool>> func);

        public Task<Pedido> GetItem(Expression<Func<Pedido, bool>> func);
    }
}
