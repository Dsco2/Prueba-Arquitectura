using Negocio.Productos.Entidades;

namespace Negocio.Mercadeo.Entidades
{
    public class ArticuloPorLista
    {
        public int IdArticulo { get; set; }
        public int IdListaEscolar { get; set; }
        public int Cantidad { get; set; }

        #region Relaciones
        public virtual Articulo Articulo { get; set; }
        public virtual ListaEscolar ListaEscolar { get; set; }
        #endregion
    }
}
