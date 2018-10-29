using Autofac;
using Negocio.Productos.Interfaces;
using Persistencia.Mercadeo.Interfaces;
using Persistencia.Mercadeo.Repositorios;
using Persistencia.Productos.Repositorios;
using System.Reflection;
using Module = Autofac.Module;

namespace IoC
{
    public class ModuloCore: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //builder.RegisterType<ServicioArticulo>().As<IServicioArticulo>();
            //builder.RegisterType<ServicioLista>().As<IServicioLista>();

            var negocioAssembly = Assembly.Load("Negocio");
            builder.RegisterAssemblyTypes(negocioAssembly).AsImplementedInterfaces();

            builder.RegisterType<RepositorioArticulo>().As<IRepositorioArticulo>();
            builder.RegisterType<RepositorioLista>().As<IRepositorioLista>();

        }
    }
}
