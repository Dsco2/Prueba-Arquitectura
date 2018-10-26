using Microsoft.AspNetCore.Mvc;
using Persistencia.Mercadeo.Interfaces;

namespace API.Controllers.Mercadeo
{
    [Route("api/Mercadeo/[controller]")]
    public class ListaEscolarController
    {
        private readonly IServicioLista _servicioLista;

        public ListaEscolarController(IServicioLista servicioLista)
        {
            _servicioLista = servicioLista;
        }


        [HttpPost]
        public void Post([FromBody] int anio)
        {
            _servicioLista.CrearLista(anio);
        }


        [HttpPost]
        [Route("crear-apl")]
        public void CrearArticuloPorLista([FromBody] int idArticulo)
        {
            _servicioLista.CrearArticuloPorLista(idArticulo);
        }
    }
}
