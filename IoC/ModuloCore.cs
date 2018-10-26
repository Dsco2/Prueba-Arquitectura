using Autofac;
using Negocio.Productos.Interfaces;
using Negocio.Productos.Servicios;
using Persistencia.Mercadeo.Interfaces;
using Persistencia.Mercadeo.Repositorios;
using Persistencia.Mercadeo.Servicio;
using Persistencia.Productos.Repositorios;

namespace IoC
{
    public class ModuloCore: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ServicioArticulo>().As<IServicioArticulo>();
            builder.RegisterType<RepositorioArticulo>().As<IRepositorioArticulo>();
            builder.RegisterType<ServicioLista>().As<IServicioLista>();
            builder.RegisterType<RepositorioLista>().As<IRepositorioLista>();

        }
    }
}
