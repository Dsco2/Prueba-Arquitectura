using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Negocio.Productos.Entidades;

namespace Persistencia.Productos.Mapas
{
    public class ProductoMapa : IEntityTypeConfiguration<Producto>
    {
        public void Configure(EntityTypeBuilder<Producto> builder)
        {
            builder.ToTable("Productos", "prods");
            builder.HasKey(x => x.IdProducto);
            builder.Property(x => x.Nombre).HasMaxLength(60);
            builder.Property(x => x.NombreBuscador).HasMaxLength(200);
            builder.HasOne(x => x.Marca);
        }
    }
}
