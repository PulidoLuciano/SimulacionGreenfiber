using Dominio.Maquinas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    enum NivelBasura {
        EXCESIVO = 0,
        INTERMEDIO,
        ESCASO,
    }

    public class Linea
    {
        Trituradora MaquinaTrituradora = new Trituradora();
        Limpiadora MaquinaLimpiadora = new Limpiadora();
        Refinadora MaquinaRefinadora = new Refinadora();
        Empaquetadora MaquinaEmpaquetadora = new Empaquetadora();

        // Resultados totales.
        public double PapelNetoReciclado = 0;
        public double ProductoNetoProducido = 0;
        public double TotalBolsas = 0;
        public double BasuraProducida = 0;

        // Cantidades segun nivel de basura
        double PapelEscaso = 0;
        double PapelIntermedio = 0;
        double PapelExcesivo = 0;

        // Cantidad en almacenes. Dinamicos e interdependientes a lo largo de la simulacion.
        double AlmacenRecolectado = 0;
        double AlmacenPapel = 0;
        double AlmacenBasura = 0;
        double AlmacenFibra = 0;
        double AlmacenCelulosa = 0;

        // Pedidas de capacidades de maquinas en Kg. "Lo que podria haber producido"
        double DesperdicioTrituradora = 0;
        double DesperdicioRefinadora = 0;
        double DesperdicioEmpaquetadora = 0;

        // Consumos de quimicos.
        double ConsumoBorax = 0;
        double ConsumoAcidoBorico = 0;

        public void iniciar()
        {
            int horas = 8;
            double u = 0;
            List<double> nums = [];

            while (horas > 0)
            {
                // ----- RECOLECCION -----
                double MasaRecolectada = 0;
                NumerosAleatorios.Distribuciones.Uniform(1500, 2000, ref MasaRecolectada);

                AlmacenRecolectado += MasaRecolectada;

                // ----- TRITURACION -----
                double MasaTriturada = 0;
                NumerosAleatorios.Distribuciones.Normal(MaquinaTrituradora.CapacidadPromedio, 60, ref MasaTriturada);

                if(MasaTriturada > AlmacenRecolectado)
                {
                    DesperdicioTrituradora += MasaTriturada - AlmacenRecolectado;
                    MasaTriturada = AlmacenRecolectado;
                    AlmacenRecolectado = 0;
                }
                else
                {
                    AlmacenRecolectado -= MasaTriturada;
                }

                // ----- LIMPIEZA -----
                NumerosAleatorios.Generador.G(ref u);

                double porcPapel = 0;
                NivelBasura nivelBasura;

                if (u <= 0.2)
                {
                    nivelBasura = NivelBasura.ESCASO;

                    NumerosAleatorios.Generador.G(ref u);

                    NumerosAleatorios.Distribuciones.Uniform(0.90, 0.98, ref porcPapel);

                }
                else if (u <= 0.95)
                {
                    nivelBasura = NivelBasura.INTERMEDIO;

                    NumerosAleatorios.Distribuciones.Normal(0.7,0.08, ref porcPapel);
                }
                else
                {
                    nivelBasura = NivelBasura.EXCESIVO;

                    NumerosAleatorios.Distribuciones.Normal(0.5, 0.05, ref porcPapel);
                }

                double Papel = MasaTriturada * porcPapel;
                double Basura = MasaTriturada * (1 - porcPapel);

                if (nivelBasura == NivelBasura.ESCASO) {
                    PapelEscaso += Papel;
                }
                else if (nivelBasura == NivelBasura.INTERMEDIO)
                {
                    PapelIntermedio += Papel;
                }
                else
                {
                    PapelExcesivo += Papel;
                }

                AlmacenPapel += Papel;
                AlmacenBasura += Basura;

                // ----- REFINACION -----
                double MasaFibra = 0;
                NumerosAleatorios.Distribuciones.Normal(MaquinaRefinadora.CapacidadPromedio, 60, ref MasaFibra);

                if(MasaFibra > AlmacenPapel)
                {
                    DesperdicioRefinadora += MasaFibra - AlmacenPapel;
                    MasaFibra = AlmacenPapel;
                    AlmacenPapel = 0;
                }
                else
                {
                    AlmacenPapel -= MasaFibra;
                }

                AlmacenFibra += MasaFibra;
                PapelNetoReciclado += MasaFibra;

                double porcQuimico = 0;
                NumerosAleatorios.Distribuciones.Uniform(0.2, 0.25, ref porcQuimico);

                double MasaQuimicos = MasaFibra * porcQuimico;
                ConsumoBorax += (MasaQuimicos - 11.6) / 1.185;
                ConsumoAcidoBorico += 11.6 + (0.185 * ConsumoBorax);

                double MasaCelusa = MasaFibra + MasaQuimicos;
                AlmacenCelulosa += MasaCelusa;

                // ----- EMPAQUETADO -----
                double MasaEmpaquetada = 0;
                NumerosAleatorios.Distribuciones.Normal(MaquinaEmpaquetadora.CapacidadPromedio, 60, ref MasaEmpaquetada);

                if (MasaEmpaquetada > AlmacenCelulosa)
                {
                    DesperdicioEmpaquetadora += MasaEmpaquetada - AlmacenCelulosa;
                    MasaEmpaquetada = AlmacenCelulosa;
                    AlmacenCelulosa = 0;
                }
                else
                {
                    AlmacenCelulosa -= MasaEmpaquetada;
                }

                double MasaBolsa = 0;
                while (MasaEmpaquetada > 13)
                {
                    NumerosAleatorios.Distribuciones.Uniform(13, 15, ref  MasaBolsa);
                    MasaEmpaquetada -= MasaBolsa;
                    ProductoNetoProducido += MasaBolsa;
                    TotalBolsas++;
                }

                AlmacenCelulosa += MasaEmpaquetada;
                horas--;
            }


            Console.WriteLine($"PapelNetoReciclado: {PapelNetoReciclado} Kg");
            Console.WriteLine($"ProductoNetoProducido: {ProductoNetoProducido} Kg");
            Console.WriteLine($"TotalBolsas: {TotalBolsas} bolsas");
            Console.WriteLine($"LotePapel: {LotePapel} Kg");

            Console.WriteLine($"Desperdicio Refinadora: {DesperdicioRefinadora} Kg");
            Console.WriteLine($"Desperdicio Empaquetadora: {DesperdicioEmpaquetadora} Kg");

            Console.WriteLine($"AlmacenCelulosa: {AlmacenCelulosa} Kg");
            Console.WriteLine($"Basura: {BasuraProducida} Kg");
        }
    }
}
