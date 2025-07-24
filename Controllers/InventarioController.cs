using InventarioAPI.Modelos;
using InventarioAPI.Servicio;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace InventarioAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventarioController (IArticuloService articuloService) : ControllerBase
    {
        // GET: api/<InventarioController>
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetAll()
        {
            var items = await articuloService.GetAllItems();

            return new ApiResponse(success:true, message:"Consulta exitosa",data:items);
        }

        // GET api/<InventarioController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ApiResponse>> Get(int id)
        {
            var items = await articuloService.GetItem(x=>x.ArticuloId==id);

            return new ApiResponse(success: true, message: items==null ?"No existen articulos con el Id proporcionado":"Consulta exitosa", data: items);
        }

        // POST api/<InventarioController>
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> Post([FromBody]ArticuloRequest articulo)
        {
            var newItem = await articuloService.CreateItem(new Articulo
            {
                Codigo = articulo.Codigo,
                Nombre = articulo.Nombre,
                Existencias = articulo.Existencias,
                PrecioUnitario = articulo.PrecioUnitario
            });

            return new ApiResponse(success: true, message: "Creación exitosa", data: newItem);

        }

        // PUT api/<InventarioController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<ApiResponse>> Put(int id,[FromBody]ArticuloRequest articulo)
        {
            var newItem = await articuloService.Update(new Articulo
            {
                ArticuloId=id,
                Codigo = articulo.Codigo,
                Nombre = articulo.Nombre,
                Existencias = articulo.Existencias,
                PrecioUnitario = articulo.PrecioUnitario
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
