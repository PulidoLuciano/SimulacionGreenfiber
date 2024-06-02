using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Limpiadora
    {
        private double _potencia = 63;
        public double Potencia { get { return _potencia; } set { _potencia = value; } }
    }
}
