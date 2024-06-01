using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class SimulacionProduccion
    {
        public ArrayList Lineas = new ArrayList();

        public void simular()
        {
            foreach(Linea l in Lineas)
            {
                l.iniciar();
            }
        }

    }
}
