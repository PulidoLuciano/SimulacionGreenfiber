using Presentacion.Tareas;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vistas.Interfaces;

namespace Presentacion.Presentadores
{
    public class PresentadorContenedora : PresentadorBase<TareaContenedora, IVistaContenedora>
    {
        public PresentadorContenedora(IVistaContenedora vista) : base(vista)
        {
            Vista.AlCargar += IniciarVistaPrincipal;
        }

        public void IniciarVistaPrincipal(object sender, EventArgs e)
        {
            Tarea.IniciarTarea<TareaPrincipal>(Vista);
        }
    }
}
