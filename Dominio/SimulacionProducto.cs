using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public double AreaParedm2 { get; set; }
        public int Horas {  get; set; }
        public int MaterialElegido { get; set; }
        public double RValue { get { return (EspesorCm / 100) / Conductividad; } }
        public double RValueInches { get { return RValue * (2.54); } }
        public double Conductividad { 
            get
            {
                return (MaterialElegido == 0) ? 0.039 : (MaterialElegido == 1) ? 0.67 : 0.044;
            } 
        }

        public double Densidad
        {
            get
            {
                return (MaterialElegido == 0) ? 60 : (MaterialElegido == 1) ? 875 : 220;
            }
        }
        public double CalorEspecifico
        {
            get
            {
                return (MaterialElegido == 0) ? 2110 : (MaterialElegido == 1) ? 850 : 795;
            }
        }

        public SimulacionProducto()
        {
            Horas = 0;
            TempInterior = 25;
            TempExterior = 5;
            EspesorCm = 14;
            AreaParedm2 = 20;
            MaterialElegido = 0;
        }

        public void simularHora()
        {
            double Temp1 = (TempExterior > TempInterior) ? TempExterior + 273.15 : TempInterior + 273.15;
            double Temp2 = (TempExterior > TempInterior) ? TempInterior + 273.15 : TempExterior + 273.15;
            double EnergiaTransmitida = AreaParedm2 / RValue * (Temp1 - Temp2);
            double deltaT = (EnergiaTransmitida * 3600) / (Densidad * AreaParedm2 * (EspesorCm / 100) * CalorEspecifico);
            TempInterior -= deltaT;
            Horas++;
        }

        public void reiniciar()
        {
            TempInterior = 25;
            TempExterior = 5;
            AreaParedm2 = 20;
            Horas = 0;
        }
    }
}
