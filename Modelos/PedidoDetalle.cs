using System;
using System.Collections.Generic;

namespace InventarioAPI.Modelos;

public partial class PedidoDetalle
{
    public long PedidoDetalleId { get; set; }

    public long PedidoId { get; set; }

    public long ArticuloId { get; set; }

    public int Cantidad { get; set; }

    public virtual Articulo Articulo { get; set; } = null!;

    public virtual Pedido Pedido { get; set; } = null!;
}
