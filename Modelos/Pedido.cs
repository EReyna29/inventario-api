using System;
using System.Collections.Generic;

namespace InventarioAPI.Modelos;

public partial class Pedido
{
    public long PedidoId { get; set; }

    public DateTime Fecha { get; set; }

    public virtual ICollection<PedidoDetalle> PedidoDetalles { get; set; } = new List<PedidoDetalle>();
}
