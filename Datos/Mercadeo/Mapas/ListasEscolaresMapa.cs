using Microsoft.EntityFrameworkCore;
using Negocio.Mercadeo.Entidades;


namespace Persistencia.Mercadeo.Mapas
{
    public class ListasEscolaresMapa : IEntityTypeConfiguration<ListaEscolar>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ListaEscolar> builder)
        {
            builder.ToTable("ListasEscolares", "mkt");
            builder.HasKey(x => x.IdListaEscolar);
        }
    }
}
