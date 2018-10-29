using Microsoft.EntityFrameworkCore;
using Negocio.Mercadeo.Entidades;
using Negocio.Productos.Entidades;
using Persistencia.Mercadeo.Mapas;
using Persistencia.Productos.Mapas;

namespace Persistencia
{
    public class ContextoPrincipal : DbContext
    {
        public DbSet<Articulo> Articulos { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<ListaEscolar> ListasEscolares { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<ArticuloPorLista> ArticulosPorLista { get; set; }
        public DbSet<DistintivoPagina> DistintivosPaginas { get; set; }
        public DbSet<DistintivosProducto> DistintivosProductos { get; set; }

        public ContextoPrincipal(DbContextOptions<ContextoPrincipal> options) : base(options) { }

        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ArticuloMapa());
            modelBuilder.ApplyConfiguration(new ArticuloPorListaMapa());
            modelBuilder.ApplyConfiguration(new ListasEscolaresMapa());
            modelBuilder.ApplyConfiguration(new MarcaMapa());
            modelBuilder.ApplyConfiguration(new ProductoMapa());

            modelBuilder.ApplyConfiguration(new DistintivoPaginaMapa());
            modelBuilder.ApplyConfiguration(new DistintivoProductoMapa());
            base.OnModelCreating(modelBuilder);
        }
    }
}
