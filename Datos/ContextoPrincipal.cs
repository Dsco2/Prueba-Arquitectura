using Microsoft.EntityFrameworkCore;
using Negocio.Productos.Entidades;
using Persistencia.Mercadeo.Mapas;
using Persistencia.Productos.Mapas;

namespace Persistencia
{
    public class ContextoPrincipal : DbContext
    {
        public DbSet<Articulo> Articulos { get; set; }
        public DbSet<Articulo> ListasEscolares { get; set; }
        public DbSet<Articulo> ArticulosPorLista { get; set; }
        public ContextoPrincipal(DbContextOptions<ContextoPrincipal> options) : base(options) { }

        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ArticuloMapa());
            modelBuilder.ApplyConfiguration(new ArticuloPorListaMapa());
            modelBuilder.ApplyConfiguration(new ListasEscolaresMapa());
            base.OnModelCreating(modelBuilder);
        }
    }
}
