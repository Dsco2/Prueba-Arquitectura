using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Mercadeo.Interfaces
{
    public interface IServicioLista
    {
        bool CrearLista(int Anio);
        bool CrearArticuloPorLista(int anio);
    }
}
