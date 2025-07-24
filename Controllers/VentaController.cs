using InventarioAPI.Modelos;
using InventarioAPI.Servicio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InventarioAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentaController(IPedidoService pedidoService,IPedidoDetalleService pedidoDetalleService) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetAll()
        {
            var items = await pedidoService.GetAllItems();

            return new ApiResponse(success: true, message: "Consulta exitosa", data: items);
        }

        // GET api/<InventarioController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ApiResponse>> Get(int id)
        {
            var items = await pedidoService.GetItem(x => x.PedidoId == id);

            return new ApiResponse(success: true, message: items == null ? "No existen articulos con el Id proporcionado" : "Consulta exitosa", data: items);
        }

        // POST api/<InventarioController>
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> Post([FromBody] PedidoRequest pedido)
        {
            var newItem = await pedidoService.CreateItem(new Pedido
            {
                Fecha=pedido.Fecha
            });

            return new ApiResponse(success: true, message: "Creación exitosa", data: newItem);

        }

        // PUT api/<InventarioController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<ApiResponse>> Put(int id, [FromBody] PedidoRequest pedido)
        {
            var newItem = await pedidoService.Update(new Pedido
            {
                PedidoId = id,
                Fecha=pedido.Fecha
            });

            return new ApiResponse(success: true, message: "Actualización exitosa", data: newItem);
        }

        // DELETE api/<InventarioController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
