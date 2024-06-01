using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    internal class Refinadora
    {
        public double CapacidadPromedio { get { return 1280; } }
        public double Potencia { get; set; }

        public double Consumo
        {
            get { return 8 * Potencia; }
        }
    }
}
