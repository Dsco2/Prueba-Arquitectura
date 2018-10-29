using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Negocio.Productos.Entidades;

namespace Persistencia.Productos.Mapas
{
    public class DistintivoPaginaMapa : IEntityTypeConfiguration<DistintivoPagina>
    {
        public void Configure(EntityTypeBuilder<DistintivoPagina> builder)
        {
            builder.ToTable("DistintivosPagina", "prods");
            builder.HasKey(x => x.IdDistintivo);

            builder.Property(x => x.Texto).HasMaxLength(90);
            builder.Property(x => x.Texto).HasMaxLength(6);
        }
    }
}
