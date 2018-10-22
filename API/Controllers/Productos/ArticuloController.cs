using Microsoft.AspNetCore.Mvc;
using Negocio.Productos.Interfaces;


namespace API.Controllers.Productos
{
    [Route ("api/Productos/[controller]")]
    public class ArticuloController : Controller
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
    }
}
