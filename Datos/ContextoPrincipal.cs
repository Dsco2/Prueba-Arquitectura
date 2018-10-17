using Microsoft.EntityFrameworkCore;
using Negocio.Productos.Entidades;
using Persistencia.Productos.Mapas;

namespace Persistencia
{
    public class ContextoPrincipal : DbContext
    {
        public DbSet<Articulo> Articulos { get; set; }
        public ContextoPrincipal(DbContextOptions<ContextoPrincipal> options) : base(options) { }

        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ArticuloMapa());
            base.OnModelCreating(modelBuilder);
        }
    }
}
