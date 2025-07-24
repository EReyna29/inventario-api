using System;
using System.Collections.Generic;

namespace InventarioAPI.Modelos;

public partial class Ventum
{
    public long PedidoId { get; set; }

    public DateTime Fecha { get; set; }

    public long PedidoDetalleId { get; set; }

    public long ArticuloId { get; set; }

    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public int Existencias { get; set; }

    public decimal PrecioUnitario { get; set; }

    public int Cantidad { get; set; }

    public decimal? Total { get; set; }
}
