using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Maquinas
{
    internal class Refinador
    {
        private double _papel_entrada;
        private double _ratio_util = 1; // cte
        private double _ratio_quimicos = 0.25; // Puede variar entre 0.20 - 0.25
        private double _velocidad;

        public Refinador() { }

        public Refinador(double papel_entrada, double velocidad)
        {
            _papel_entrada = papel_entrada;
            _velocidad = velocidad;
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

        public double Borax
        {
            get { return (_papel_entrada * _ratio_quimicos - 11.6) / 1.185; }
        } // kg

        public double AcidoBorico
        {
            get { return 11.6 + 0.185 * Borax; }
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
