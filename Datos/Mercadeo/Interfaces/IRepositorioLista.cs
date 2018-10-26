using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Mercadeo.Interfaces
{
    public interface IRepositorioLista
    {
        bool CrearLista(int anio);
        bool CrearArticuloPorLista(int idArticulo);
    }
}
