using Negocio.Productos.Interfaces;


namespace Negocio.Productos.Servicios
{
    public class ServicioArticulo : IServicioArticulo
    {
        //public bool CrearArticulo(string nombreArticulo)
        //{
        //    throw new System.NotImplementedException();
        //}

        private readonly IRepositorioArticulo _repositorioArticulo;

        public ServicioArticulo(IRepositorioArticulo respositoArticulo)
        {
            _repositorioArticulo = respositoArticulo;
        }

        public bool CrearArticulo(string nombreArticulo)
        {
            return _repositorioArticulo.CrearArticulo(nombreArticulo);
        }



    }
}
