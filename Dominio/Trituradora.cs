using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumerosAleatorios;

namespace Dominio
{
    internal class Trituradora
    {
        public double CapacidadPromedio { get { return 1800; } } 
        public double Potencia { get; set; }

        public double Consumo
        {
            get { return 8 * Potencia; }
        }

    }
}
