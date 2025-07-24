using System;
using System.Collections.Generic;

namespace InventarioAPI.Modelos;

public partial class Articulo
{
    public long ArticuloId { get; set; }

    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public int Existencias { get; set; }

    public decimal PrecioUnitario { get; set; }

    public virtual ICollection<PedidoDetalle> PedidoDetalles { get; set; } = new List<PedidoDetalle>();
}
