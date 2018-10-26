using Microsoft.AspNetCore.Mvc;
using Negocio.Productos.Interfaces;
using System.Linq;

namespace API.Controllers.Productos
{
    [Route ("api/Productos/[controller]")]
    public class ArticuloController : Controller //No, fue cuando quise agregar el paquete  de npgsql
    {
        private readonly IServicioArticulo _servicioArticulo;

        public ArticuloController(IServicioArticulo servicioArticulo)
        {
            _servicioArticulo = servicioArticulo;
        }

        [HttpPost]
        public void Post([FromBody] string value)
        {
            _servicioArticulo.CrearArticulo(value);
        }

        [HttpGet]
        public IActionResult Get ()
        {
            var listaArticulos = _servicioArticulo.ObtenerArticulos();
            if (!listaArticulos.Any()) return NoContent();
            return Ok(listaArticulos);
        }


        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var Articulos = _servicioArticulo.ObtenerArticuloPorId(id);
            if (Articulos == null) return NoContent();
            return Ok(Articulos);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id,[FromBody]decimal precio)
        {
            if (precio == 0) return BadRequest();
            var exitoso = _servicioArticulo.ActualizarPrecio(id, precio);
            if (!exitoso) return NoContent();
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id == 0) return BadRequest();
            var exitoso = _servicioArticulo.EliminarArticulo(id);
            if (!exitoso) return NoContent();
            return Ok();
        }



    }
}
//Si