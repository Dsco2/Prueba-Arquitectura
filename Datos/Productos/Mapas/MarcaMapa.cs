using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Negocio.Productos.Entidades;

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
