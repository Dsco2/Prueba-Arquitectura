using System.ComponentModel.DataAnnotations;

namespace Negocio.ModelosVista.Productos
{
    public class ArticuloVm
    {
        [Required]
        [StringLength (45, MinimumLength = 3)]
        public string Nombre { get; set; }
        [Range (3, double.MaxValue)]
        public decimal Precio { get; set; }
    }
}
