using Negocio.Productos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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