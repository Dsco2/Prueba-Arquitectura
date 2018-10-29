using Negocio.Productos.Entidades;
using System.Collections.Generic;

namespace Negocio.Productos.Interfaces
{
    public interface IServicioArticulo
    {
        bool CrearArticulo(Articulo articulo);
        List<Articulo> ObtenerArticulos();
        Articulo ObtenerArticuloPorId(int id);
        bool ActualizarPrecio(int id, decimal precio);
        bool EliminarArticulo(int id);
    }
}
