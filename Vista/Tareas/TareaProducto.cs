using Presentacion.Presentadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion.Tareas
{
    public class TareaProducto : TareaBase
    {
        public TareaProducto() { }

        public override void Iniciar()
        {
            NavegarA<PresentadorProducto>();
        }
    }
}
