using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Productos.Interfaces
{
    public interface IRepositorioArticulo
    {
        bool CrearArticulo(string nombre);
    }
}