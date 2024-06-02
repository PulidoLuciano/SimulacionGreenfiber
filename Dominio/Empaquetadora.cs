using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Empaquetadora
    {
        private double _capacidadPromedio = 2520;
        private double _potencia = 60;
        public double CapacidadPromedio { get { return _capacidadPromedio; } set { _capacidadPromedio = value; } }
        public double Potencia { get { return _potencia; } set { _potencia = value; } }
    }
}
