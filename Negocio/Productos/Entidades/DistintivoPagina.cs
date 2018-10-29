using System.Collections.Generic;

namespace Negocio.Productos.Entidades
{
    public class DistintivoPagina
    {
        public int IdDistintivo { get; set; }
        public TipoDistintivo Tipo { get; set; }
        public string Texto { get; set; }
        public string CodigoColor { get; set; }

        #region relaciones
        public virtual ICollection<DistintivosProducto> DistintivosProductos { get; set; }
        #endregion
    }
}
