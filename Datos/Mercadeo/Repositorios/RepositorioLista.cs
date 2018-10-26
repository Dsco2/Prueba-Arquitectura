using Negocio.Mercadeo.Entidades;
using Persistencia.Mercadeo.Interfaces;
using System;

namespace Persistencia.Mercadeo.Repositorios
{
    public class RepositorioLista : IRepositorioLista
    {
        private readonly ContextoPrincipal _contexto;

        public RepositorioLista(ContextoPrincipal contexto)
        {
            _contexto = contexto;
        }

        public bool CrearArticuloPorLista(int idArticulo)
        {
            try
            {
                _contexto.ArticulosPorLista.Add(new ArticuloPorLista
                {
                    IdArticulo = idArticulo,
                    IdLista = 2010
                });
                _contexto.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public bool CrearLista(int anio)
        {
            try
            {
                _contexto.ListasEscolares.Add(new ListaEscolar
                {
                    Anio = anio
                });
                _contexto.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }


    }
}
