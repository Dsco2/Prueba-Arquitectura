using Negocio.Productos.Entidades;
using Negocio.Productos.Interfaces;
using System;

namespace Persistencia.Productos.Repositorios
{
    public class RepositorioArticulo : IRepositorioArticulo
    {
        private readonly ContextoPrincipal _contexto;

        public RepositorioArticulo(ContextoPrincipal contexto)
        {
            _contexto = contexto;
        }

        public bool CrearArticulo(string nombre)
        {
            try
            {
                _contexto.Articulos.Add(new Articulo
                {
                    Nombre = nombre
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
