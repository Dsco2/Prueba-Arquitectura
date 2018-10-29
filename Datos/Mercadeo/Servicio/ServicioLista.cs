using Persistencia.Mercadeo.Interfaces;

namespace Persistencia.Mercadeo.Servicio
{
    public class ServicioLista : IServicioLista
    {

        private readonly IRepositorioLista _repositorioLista;

        public ServicioLista(IRepositorioLista respositoLista)
        {
            _repositorioLista = respositoLista;
        }

        public bool CrearArticuloPorLista(int idArticulo)
        {
            return _repositorioLista.CrearArticuloPorLista(idArticulo);
        }

        public bool CrearLista(int anio)
            {
            return _repositorioLista.CrearLista(anio);
            }
        }
    }
