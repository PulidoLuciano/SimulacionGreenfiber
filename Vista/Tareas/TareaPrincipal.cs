using Presentacion.Presentadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion.Tareas
{
    public class TareaPrincipal : TareaBase
    {
        public TareaPrincipal() { }

        public override void Iniciar()
        {
            NavegarA<PresentadorPrincipal>();
        }
    }
}
