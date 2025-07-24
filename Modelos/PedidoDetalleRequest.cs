namespace InventarioAPI.Modelos
{
    public class PedidoDetalleRequest
    {
        public long PedidoId { get; set; }

        public long ArticuloId { get; set; }

        public int Cantidad { get; set; }
    }
}
