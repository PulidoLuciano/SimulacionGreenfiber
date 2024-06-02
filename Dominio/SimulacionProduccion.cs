using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class SimulacionProduccion
    {
        public List<Linea> LineasProduccion = new List<Linea>();
        public int HorasJornada = 8;
        public double MinPapel = 1500;
        public double MaxPapel = 2000;

        public void simular()
        {
            foreach(Linea l in LineasProduccion)
            {
                l.iniciar(HorasJornada, MinPapel, MaxPapel);

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
