using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Maquinas
{
    internal class Tolva
    {
        private double _papel_entrada;
        private double _ratio_util = 1; // cte
        private double _velocidad;

        public Tolva() { }

        public Tolva(double papel_entrada)
        {
            _papel_entrada = papel_entrada;
        }

        public double PapelEntrada
        {
            get { return _papel_entrada; }
            set { _papel_entrada = value; }
        } // kg

        public double PapelSalida
        {
            get { return _papel_entrada * _ratio_util; }
        } // kg

        public double Velocidad
        {
            get { return _velocidad; }
            set { _velocidad = value; }
        } // kg/h

        public double Tiempo
        {
            get { return _velocidad * _papel_entrada; }
        } // h
    }
}
