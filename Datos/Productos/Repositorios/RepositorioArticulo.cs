using Negocio.Productos.Entidades;
using Negocio.Productos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Persistencia.Productos.Repositorios
{
    public class RepositorioArticulo : IRepositorioArticulo
    {
        private readonly ContextoPrincipal _contexto;

        public RepositorioArticulo(ContextoPrincipal contexto)
        {
            _contexto = contexto;
        }

        public bool ActualizarPrecio(int id, decimal precio)
        {
            try
            {
                var articulo = _contexto.Articulos.FirstOrDefault(x => x.IdArticulo == id);
                if (articulo == null) return false;
                articulo.Precio = precio;
                _contexto.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            
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

        public List<Articulo> ObtenerArticulos()
        {
            try
            {
                var query = _contexto.Articulos.ToList();
                return query;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new List<Articulo>();
            }
        }

        public Articulo ObtenerArticulosPorId(int id)
        {
            try
            {
                var temp = _contexto;
                var art = temp.Articulos;

                var query = art.FirstOrDefault(x => x.IdArticulo == id);
                
                return query;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return  null;
            }
           

        }
    }
}
