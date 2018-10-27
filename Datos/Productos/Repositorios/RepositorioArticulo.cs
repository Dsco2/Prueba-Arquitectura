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

        public bool CrearArticulo(Articulo articulo)
        {
            try
            {
                _contexto.Articulos.Add(articulo);  
                _contexto.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public bool EliminarArticulo(int id)
        {
            try
            {
                var articulo = _contexto.Articulos.FirstOrDefault(x => x.IdArticulo == id);
                if (articulo == null) return false;
                articulo.FechaBorrado = DateTime.UtcNow;
                _contexto.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public List<Articulo> ObtenerArticulos()
        {
            try
            {
                var query = _contexto.Articulos
                .Where(x => !x.FechaBorrado.HasValue)
                .ToList();
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
                var query = _contexto.Articulos
                    .Where(x => !x.FechaBorrado.HasValue)
                    .FirstOrDefault(x => x.IdArticulo == id);
                
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
