using Negocio.Productos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Productos.Interfaces
{
    public interface IServicioArticulo
    {
        bool CrearArticulo(string nombreArticulo);
        List<Articulo> ObtenerArticulos();
        Articulo ObtenerArticuloPorId(int id);
        bool ActualizarPrecio(int id, decimal precio);
    }
}
