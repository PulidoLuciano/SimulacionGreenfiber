using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class SimulacionProducto
    {
        public double TempInterior { get; set; }
        public double TempExterior { get; set; }
        public double EspesorCm { get; set; }

        public SimulacionProducto()
        {
            TempInterior = 20;
            TempExterior = 30;
            EspesorCm = 14;
        }

        public void simular()
        {
            double Temp1 = (TempExterior > TempInterior) ? TempExterior : TempInterior;
            double Temp2 = (TempExterior > TempInterior) ? TempInterior : TempExterior;
            /*deltaTemp = 
            (1 / EspesorCm * 0,039) * (Temp1 - Temp2);*/ 
        }
    }
}
