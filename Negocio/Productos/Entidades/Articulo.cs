using FluentValidation;
using FluentValidation.Results;
using Negocio.Productos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Productos.Entidades
{
    public class Articulo
    {
        public int IdArticulo { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public DateTime? FechaBorrado { get; set; }

        public ValidationResult Validarse()
        {
            var articuloValidador = new ArticuloValidador();
            var resultadosValidacion = articuloValidador.Validate(this);
            return resultadosValidacion;
        }



    }

    public class ArticuloValidador : AbstractValidator<Articulo>
    {
        public ArticuloValidador()
        {
            RuleFor(x => x.Nombre).Length(1, 45);
            RuleFor(x => x.Precio).GreaterThan(0);
        }
    }



}
