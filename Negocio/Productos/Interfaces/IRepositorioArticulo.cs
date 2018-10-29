using Negocio.Productos.Entidades;
using System.Collections.Generic;

namespace Negocio.Productos.Interfaces
{
    public interface IRepositorioArticulo
    {
        bool CrearArticulo(Articulo articulo);
        List<Articulo> ObtenerArticulos();
        Articulo ObtenerArticulosPorId(int id);
        bool ActualizarPrecio(int id, decimal precio);
        bool EliminarArticulo(int id);
    }
}