using Presentacion.Interfaces;
using Presentacion.Tareas;
using Presentacion.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vistas;

namespace Presentacion.Presentadores
{
    public class PresentadorPrincipal : PresentadorBase<TareaPrincipal, IVistaPrincipal>
    {
        public PresentadorPrincipal(IVistaPrincipal vista) : base(vista)
        {
            Vista.AbrirVistaProducto += AbrirVistaProducto;
        }

        public void AbrirVistaProducto(object sender, EventArgs e)
        {
            Tarea.NavegarA<PresentadorProducto>();
        }
    }
}
