using Autofac;
using Negocio.Productos.Interfaces;
using Negocio.Productos.Servicios;

namespace IoC
{
    public class ModuloCore: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ServicioArticulo>().As<IServicioArticulo>();
        }
    }
}
