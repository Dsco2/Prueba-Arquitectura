﻿using System.Collections.Generic;
using Negocio.Productos.Entidades;
using Negocio.Productos.Interfaces;


namespace Negocio.Productos.Servicios
{
    public class ServicioArticulo : IServicioArticulo
    {
        private readonly IRepositorioArticulo _repositorioArticulo;

        public ServicioArticulo(IRepositorioArticulo respositoArticulo)
        {
            _repositorioArticulo = respositoArticulo;
        }

        public bool ActualizarPrecio(int id, decimal precio)
        {
            return _repositorioArticulo.ActualizarPrecio(id, precio);
        }

        public bool CrearArticulo(Articulo articulo)
        {
            //var resultadoValidacion = articulo.Validarse();
            if (!articulo.Validarse().IsValid) return false;
            return _repositorioArticulo.CrearArticulo(articulo);
        }

        public bool EliminarArticulo(int id)
        {
            return _repositorioArticulo.EliminarArticulo(id);
        }

        public Articulo ObtenerArticuloPorId(int id)
        {
            return _repositorioArticulo.ObtenerArticulosPorId(id);
        }

        public List<Articulo> ObtenerArticulos()
        {
            return _repositorioArticulo.ObtenerArticulos();
        }
    }
}
