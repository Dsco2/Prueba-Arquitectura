using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Productos.Entidades
{
    public class DistintivosProducto 
    {
        public int IdDistintivo { get; set; }
        public DistintivoPagina Distintivo { get; set; }
        public int IdProducto { get; set; }
        public Producto Producto { get; set; }
    }
}
