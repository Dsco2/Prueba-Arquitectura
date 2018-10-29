using Microsoft.EntityFrameworkCore;
using Negocio.Mercadeo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Productos.Mapas
{
    public class ArticuloPorListaMapa : IEntityTypeConfiguration<ArticuloPorLista>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ArticuloPorLista> builder)
        {
            builder.ToTable("ArticulosPorLista", "mkt");
            builder.HasKey(x => new { x.IdArticulo, x.IdListaEscolar });
            builder.HasOne(x => x.Articulo);
            builder.HasOne(x => x.ListaEscolar);
        }
    }
}
