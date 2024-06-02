using Dominio;
using Presentacion.Componentes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion.Interfaces
{
    public interface IVistaPrincipal : IVista
    {
        List<ControlLineaProduccion> ControlesLineas { get; }
        
        event EventHandler AbrirVistaProducto;
        event EventHandler AgregarLineaProduccion;
        event EventHandler QuitarLineaProduccion;
        event EventHandler Simular;
        event EventHandler Resize;

        public void ListarLineas(List<Linea> lineas);
    }
}
