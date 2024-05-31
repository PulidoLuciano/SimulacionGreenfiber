using Presentacion.Interfaces;
using Presentacion.Presentadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion.Tareas
{
    /// <summary>
    /// Interfaz para implementar en todas las tareas que se definan.
    /// </summary>
    public interface ITarea
    {
        IVista MdiPadre { get; set; }
        void Iniciar();
        void IniciarTarea<TTarea>(IVista mdiPadre = null)
            where TTarea : ITarea;
        void NavegarA<TPresentador>(bool esDialogo = false)
            where TPresentador : IPresentador;
    }
}
