namespace InventarioAPI.Modelos
{
    public class ArticuloRequest
    {
        public string Codigo { get; set; }

        public string Nombre { get; set; }

        public int Existencias { get; set; }

        public decimal PrecioUnitario { get; set; }
    }
}
