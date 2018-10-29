using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Productos.Entidades
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public string NombreBuscador { get; set; }
        public string Descripcion { get; set; }
        public string UrlImagen { get; set; }
        public bool TieneImagen { get; set; }
        public bool Disponible { get; set; }
        public bool AgotarPorInventario { get; set; }
        public bool ListaFavor { get; set; }
        public double Peso { get; set; }
        public int SecuenciaPagina { get; set; }
        public int SecuenciaIdRemision { get; set; }

        #region Relaciones
        public int IdMarca { get; set; }
        public virtual Marca Marca { get; set; }
        #endregion
    }
}
