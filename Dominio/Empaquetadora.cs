using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    internal class Empaquetadora
    {
        public double CapacidadPromedio { get { return 2520; } }
        public double Potencia { get; set; }

        public double Consumo
        {
            get { return 8 * Potencia; }
        }
    }
}
