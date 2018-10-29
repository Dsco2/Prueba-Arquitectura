using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Negocio.Productos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Productos.Mapas
{
    public class DistintivoProductoMapa : IEntityTypeConfiguration<DistintivosProducto>
    {

        public void Configure(EntityTypeBuilder<DistintivosProducto> builder)
        {
            builder.ToTable("DistintivosProductos", "prods");
            builder.HasKey(x => new { x.IdProducto, x.IdDistintivo });

            builder.HasOne(x => x.Producto)
                .WithMany(dp => dp.DistintivosProductos)
                .HasForeignKey(x => x.IdProducto);

            builder.HasOne(x => x.Distintivo)
                .WithMany(dp => dp.DistintivosProductos)
                .HasForeignKey(x => x.IdDistintivo);
        }
    }
}

