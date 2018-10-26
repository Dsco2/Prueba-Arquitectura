using Negocio.Mercadeo.Entidades;
using Persistencia.Mercadeo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
