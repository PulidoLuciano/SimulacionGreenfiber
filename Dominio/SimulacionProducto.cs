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
    }
}
