using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Dominio
{
    public class SimulacionProduccion
    {
        public List<Linea> LineasProduccion = new List<Linea>();
        public int _horasJornada = 8;
        private double _minPapel = 1500;
        private double _maxPapel = 2000;
        public double variable = 0;

        public double TotalPapelNetoPlanta { get; set; }
        public double TotalBolsasPlanta { get; set; }
        public double ProductoNetoProducidoPlanta { get; set; }
        public double PotenciaPlanta { get; set; }
        public double ArbolesSalvadosPlanta { get; set; }

        public double ConsumoBoraxPlanta { get; set; }
        public double ConsumoAcidoBoricoPlanta { get; set; }

        public double PapelEscasoPlanta { get; set; }
        public double PapelIntermedio { get; set; }
        public double PapelExcesivoPlanta { get; set; }

        public double DesperdicioTrituracionPlanta { get; set; }
        public double BasuraTotalPlanta { get; set; }
        public double DesperdicioRefinacionPlanta { get; set; }
        public double DesperdicioEmpaquetadoPlanta { get; set; }

        public int HorasJornada
        {
            get { return _horasJornada; }
            set { _horasJornada = value; }
        }

        public double MinPapel {
            get { return _minPapel; }
            set { _minPapel = value; }
        }

        public double MaxPapel { 
            get { return _maxPapel; } 
            set { _maxPapel = value; } 
        }


        public void simular()
        {
            foreach (Linea l in LineasProduccion)
            {
                l.iniciar(HorasJornada, MinPapel, MaxPapel);

                ProductoNetoProducidoPlanta += l.ProductoNetoProducido;
                TotalBolsasPlanta += l.TotalBolsas;
                TotalPapelNetoPlanta += l.PapelNetoReciclado;
                BasuraTotalPlanta += l.AlmacenBasura;
                ConsumoAcidoBoricoPlanta += l.ConsumoAcidoBorico;
                ConsumoBoraxPlanta += l.ConsumoBorax;
                PotenciaPlanta += l.PotenciaTotal;
                ArbolesSalvadosPlanta += l.ArbolesSalvados;
                DesperdicioTrituracionPlanta += l.DesperdicioTrituradora;
                DesperdicioRefinacionPlanta += l.DesperdicioRefinadora;
                DesperdicioEmpaquetadoPlanta += l.DesperdicioEmpaquetadora;
                PapelEscasoPlanta += l.PapelEscaso;
                PapelIntermedio += l.PapelIntermedio;
                PapelExcesivoPlanta += l.PapelExcesivo;

                System.Diagnostics.Debug.WriteLine($"Producto neto producido: {l.ProductoNetoProducido} Kg");
                System.Diagnostics.Debug.WriteLine($"Total de bolsas: {l.TotalBolsas} bolsas");
                System.Diagnostics.Debug.WriteLine($"Papel neto reciclado: {l.PapelNetoReciclado} Kg");
                System.Diagnostics.Debug.WriteLine($"Total de basura: {l.AlmacenBasura} Kg");
                System.Diagnostics.Debug.WriteLine($"Consumo total de ácido bórico: {l.ConsumoAcidoBorico} Kg");
                System.Diagnostics.Debug.WriteLine($"Consumo total de bórax: {l.ConsumoBorax} Kg");
                System.Diagnostics.Debug.WriteLine($"Potencia total consumida: {l.PotenciaTotal} kW");
                System.Diagnostics.Debug.WriteLine($"Cantidad de árboles salvados: {l.ArbolesSalvados} árboles");
                
                System.Diagnostics.Debug.WriteLine($"Cantidad de papel escaso: {l.PapelEscaso} Kg");
                System.Diagnostics.Debug.WriteLine($"Cantidad de papel intermedio: {l.PapelIntermedio} Kg");
                System.Diagnostics.Debug.WriteLine($"Cantidad de papel excesivo: {l.PapelExcesivo} Kg");

                System.Diagnostics.Debug.WriteLine($"Desperdicio Trituradora: {l.DesperdicioTrituradora} Kg");
                System.Diagnostics.Debug.WriteLine($"Desperdicio Refinadora: {l.DesperdicioRefinadora} Kg");
                System.Diagnostics.Debug.WriteLine($"Desperdicio Empaquetadora: {l.DesperdicioEmpaquetadora} Kg");

                System.Diagnostics.Debug.WriteLine($"Sobrante de la etapa de recolectado: {l.AlmacenRecolectado} Kg");
                System.Diagnostics.Debug.WriteLine($"Sobrante de la etapa de limpieza: {l.AlmacenPapel} Kg");
                System.Diagnostics.Debug.WriteLine($"Sobrante de la etapa de refinacion: {l.AlmacenFibra} Kg");
                System.Diagnostics.Debug.WriteLine($"Sobrante de la etapa de empaquetado: {l.AlmacenCelulosa} Kg");
            }
        }

        public void agregarLinea()
        {
            Linea l = new Linea();
            LineasProduccion.Add(l);
        }

    }
}
