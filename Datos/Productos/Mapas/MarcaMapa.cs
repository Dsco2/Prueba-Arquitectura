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
    public class MarcaMapa : IEntityTypeConfiguration<Marca>
    {
        public void Configure(EntityTypeBuilder<Marca> builder)
        {
            builder.ToTable("Marcas", "prods");
            builder.HasKey(x => x.IdMarca);
            builder.Property(x => x.Nombre).HasMaxLength(45);
        }       
    }
}
