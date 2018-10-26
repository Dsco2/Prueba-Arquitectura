﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Productos.Entidades
{
    public class Articulo
    {
        public int IdArticulo { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public DateTime? FechaBorrado { get; set; }
    }
}
