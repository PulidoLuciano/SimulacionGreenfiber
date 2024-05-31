using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion.Interfaces
{
    public interface IVistaPrincipal : IVista
    {
        event EventHandler AbrirVistaProducto;
        event EventHandler AgregarLineaProduccion;
        event EventHandler QuitarLineaProduccion;
        event EventHandler Simular;
    }
}
