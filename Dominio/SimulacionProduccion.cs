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


        public double TotalBolsasPlanta { get; set; }
        public double ArbolesSalvadosPlanta { get; set; }
        public double MateriaPrimaIngresadaPlanta { get; set; }
        public double PapelEscasoPlanta { get; set; }
        public double PapelIntermedio { get; set; }
        public double PapelExcesivoPlanta { get; set; }
        public double BasuraTotalPlanta { get; set; }
        public double ConsumoAcidoBoricoPlanta { get; set; }
        public double ConsumoBoraxPlanta { get; set; }
        public double ProductoNetoProducidoPlanta { get; set; }

        //TRITURACIÓN
        public double ProduccionNominalTrituradoraPlanta { get; set; }
        public double ProduccionRealTrituradoraPlanta { get; set; }
        public double DesperdicioTrituracionPlanta { get; set; }
        public double SinProcesarTrituracionPlanta { get; set; }

        //REFINACIÓN
        public double ProduccionNominalRefinadoraPlanta { get; set; }
        public double ProduccionRealRefinadoraPlanta { get; set; }
        public double DesperdicioRefinacionPlanta { get; set; }
        public double SinProcesarRefinadoraPlanta { get; set; }
        //EMPAQUETADO
        public double ProduccionNominalEmpaquetadoraPlanta { get; set; }
        public double ProduccionRealEmpaquetadoraPlanta { get; set; }
        public double DesperdicioEmpaquetadoPlanta { get; set; }
        public double SinProcesarEmpaquetadoraPlanta { get; set; }
        public double TotalPapelNetoPlanta { get; set; }
        
        
        public double PotenciaPlanta { get; set; }
        

       

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

        public SimulacionProduccion()
        {
            reiniciar();
        }

        public void simular()
        {
            reiniciar();
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
                DesperdicioTrituracionPlanta += l.DesperdicioTrituradoraV2;
                DesperdicioRefinacionPlanta += l.DesperdicioRefinadoraV2;
                DesperdicioEmpaquetadoPlanta += l.DesperdicioEmpaquetadoraV2;
                PapelEscasoPlanta += l.PapelEscaso;
                PapelIntermedio += l.PapelIntermedio;
                PapelExcesivoPlanta += l.PapelExcesivo;
                MateriaPrimaIngresadaPlanta += l.MasaNominalRecolectada;
                ProduccionNominalTrituradoraPlanta += l.ProduccionNominalTrituradora;
                ProduccionRealTrituradoraPlanta += l.ProduccionRealTrituradora;
                SinProcesarTrituracionPlanta += l.AlmacenRecolectado;
                ProduccionNominalRefinadoraPlanta += l.ProduccionNominalRefinadora;
                ProduccionRealRefinadoraPlanta += l.ProduccionRealRefinadora;
                SinProcesarRefinadoraPlanta += l.AlmacenPapel;
                ProduccionNominalEmpaquetadoraPlanta += l.ProduccionNominalEmpaquetadora;
                ProduccionRealEmpaquetadoraPlanta += l.ProduccionRealEmpaquetadora;
                SinProcesarEmpaquetadoraPlanta += l.AlmacenCelulosa;


                System.Diagnostics.Debug.WriteLine($"INFORMACION GENERAL.");
                System.Diagnostics.Debug.WriteLine($"Producto neto producido: {l.ProductoNetoProducido} Kg");
                System.Diagnostics.Debug.WriteLine($"Total de bolsas: {l.TotalBolsas} bolsas");
                System.Diagnostics.Debug.WriteLine($"Papel neto reciclado: {l.PapelNetoReciclado} Kg");
                System.Diagnostics.Debug.WriteLine($"Consumo total de ácido bórico: {l.ConsumoAcidoBorico} Kg");
                System.Diagnostics.Debug.WriteLine($"Consumo total de bórax: {l.ConsumoBorax} Kg");
                System.Diagnostics.Debug.WriteLine($"Potencia total consumida: {l.PotenciaTotal} kW");
                System.Diagnostics.Debug.WriteLine($"Cantidad de árboles salvados: {l.ArbolesSalvados} árboles");
                
                //System.Diagnostics.Debug.WriteLine($"Cantidad de papel escaso: {l.PapelEscaso} Kg");
                //System.Diagnostics.Debug.WriteLine($"Cantidad de papel intermedio: {l.PapelIntermedio} Kg");
                //System.Diagnostics.Debug.WriteLine($"Cantidad de papel excesivo: {l.PapelExcesivo} Kg");

                System.Diagnostics.Debug.WriteLine($"PRODUCCION NOMINAL.");
                System.Diagnostics.Debug.WriteLine($"\t Trituradora: {l.ProduccionNominalTrituradora} Kg");
                System.Diagnostics.Debug.WriteLine($"\t Refinadora: {l.ProduccionNominalRefinadora} Kg");
                System.Diagnostics.Debug.WriteLine($"\t Empaquetdora: {l.ProduccionNominalEmpaquetadora} Kg");

                System.Diagnostics.Debug.WriteLine($"PRODUCCION REAL.");
                System.Diagnostics.Debug.WriteLine($"\t Trituradora: {l.ProduccionRealTrituradora} Kg");
                System.Diagnostics.Debug.WriteLine($"\t Refinadora: {l.ProduccionRealRefinadora} Kg");
                System.Diagnostics.Debug.WriteLine($"\t Empaquetdora: {l.ProduccionRealEmpaquetadora} Kg");

                System.Diagnostics.Debug.WriteLine($"DESPERDICIO DE CAPACIDAD.");
                System.Diagnostics.Debug.WriteLine($"\t Trituradora: {l.DesperdicioTrituradoraV2} Kg");
                System.Diagnostics.Debug.WriteLine($"\t Refinadora: {l.DesperdicioRefinadoraV2} Kg");
                System.Diagnostics.Debug.WriteLine($"\t Empaquetadora: {l.DesperdicioEmpaquetadoraV2} Kg");

                System.Diagnostics.Debug.WriteLine($"ALMACENES.");
                System.Diagnostics.Debug.WriteLine($"\t Almacen de recolección: {l.AlmacenRecolectado} Kg");
                System.Diagnostics.Debug.WriteLine($"\t Almacen de papel: {l.AlmacenPapel} Kg");
                System.Diagnostics.Debug.WriteLine($"\t Almacen de basura: {l.AlmacenBasura} Kg");
                
            }
        }

        public void agregarLinea()
        {
            Linea l = new Linea();
            LineasProduccion.Add(l);
        }

        public void reiniciar()
        {
            TotalPapelNetoPlanta = 0;
            TotalBolsasPlanta = 0;
            ProductoNetoProducidoPlanta = 0;
            PotenciaPlanta = 0;
            ArbolesSalvadosPlanta = 0;
            ConsumoBoraxPlanta = 0;
            ConsumoAcidoBoricoPlanta = 0;
            PapelEscasoPlanta = 0;
            PapelIntermedio = 0;
            PapelExcesivoPlanta = 0;
            DesperdicioTrituracionPlanta = 0;
            BasuraTotalPlanta = 0;
            DesperdicioRefinacionPlanta = 0;
            DesperdicioEmpaquetadoPlanta = 0;
            MateriaPrimaIngresadaPlanta = 0;
            ProduccionNominalTrituradoraPlanta = 0;
            ProduccionRealTrituradoraPlanta = 0;
            SinProcesarTrituracionPlanta = 0;
            ProduccionNominalRefinadoraPlanta = 0;
            ProduccionRealRefinadoraPlanta = 0;
            SinProcesarRefinadoraPlanta = 0;
            ProduccionNominalEmpaquetadoraPlanta= 0;          
            ProduccionRealEmpaquetadoraPlanta = 0;
            SinProcesarEmpaquetadoraPlanta = 0; SinProcesarEmpaquetadoraPlanta = 0;
        }
    }
}
