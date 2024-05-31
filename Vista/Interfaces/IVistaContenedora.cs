using Presentacion.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vistas.Interfaces
{
    public interface IVistaContenedora : IVista
    {
        event EventHandler AlCargar;
        
        void CerrarVista();
        void MaximizarVista();
        void MinimizarVista();

        void ArrastrarVista(MouseEventArgs e);
    }
}
