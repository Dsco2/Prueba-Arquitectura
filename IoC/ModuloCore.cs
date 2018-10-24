using Autofac;
using Negocio.Productos.Interfaces;
using Negocio.Productos.Servicios;
using Persistencia.Productos.Repositorios;

namespace IoC
{
    public class ModuloCore: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ServicioArticulo>().As<IServicioArticulo>();
            builder.RegisterType<RepositorioArticulo>().As<IRepositorioArticulo>();
        }
    }
}
