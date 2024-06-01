using Dominio.Maquinas;
using System;
using System.Collections.Generic;
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

    internal class Linea
    {
        Trituradora MaquinaTrituradora = new Trituradora();
        Limpiadora MaquinaLimpiadora = new Limpiadora();
        Refinadora MaquinaRefinadora = new Refinadora();
        Empaquetadora MaquinaEmpaquetadora = new Empaquetadora();

        // Resultados totales.
        double PapelNetoReciclado = 0;
        double ProductoNetoProducido = 0;
        double TotalBolsas = 0;

        // Cantidades segun nivel de basura
        double PapelEscaso = 0;
        double PapelIntermedio = 0;
        double PapelExcesivo = 0;

        // Cantidad en almacenes. Dinamicos e interdependientes a lo largo de la simulacion.
        double AlmacenPapel = 0;
        double AlmacenBasura = 0;
        double AlmacenCelulosa = 0;

        // Pedidas de capacidades de maquinas en Kg. "Lo que podria haber producido"
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
                // ----- TRITURACION -----
                double MasaTriturada = 0;
                NumerosAleatorios.Distribuciones.Poisson(MaquinaTrituradora.CapacidadPromedio, ref MasaTriturada);

                NumerosAleatorios.Generador.G(ref u);

                // ----- LIMPIEZA -----
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
                NumerosAleatorios.Distribuciones.Poisson(MaquinaRefinadora.CapacidadPromedio, ref MasaFibra);

                if(MasaFibra > AlmacenPapel)
                {
                    DesperdicioRefinadora += MasaFibra - AlmacenPapel;
                    PapelNetoReciclado += AlmacenPapel;
                    AlmacenPapel = 0;
                }
                else
                {
                    AlmacenPapel -= MasaFibra;
                    PapelNetoReciclado += MasaFibra;
                }

                double porcQuimico = 0;
                NumerosAleatorios.Distribuciones.Uniform(0.2, 0.05, ref porcQuimico);

                double MasaQuimicos = MasaFibra * porcQuimico;
                ConsumoBorax += (MasaQuimicos - 11.6) / 1.185;
                ConsumoAcidoBorico += 11.6 + (0.185 * ConsumoBorax);

                double MasaCelusa = MasaFibra + MasaQuimicos;
                AlmacenCelulosa += MasaCelusa;

                // ----- EMPAQUETADO -----
                double MasaEmpaquetada = 0;
                NumerosAleatorios.Distribuciones.Poisson(MaquinaEmpaquetadora.CapacidadPromedio, ref MasaEmpaquetada);

                double MasaProducto = 0;

                if (MasaEmpaquetada > AlmacenCelulosa)
                {
                    DesperdicioEmpaquetadora += MasaEmpaquetada - AlmacenCelulosa;
                    MasaProducto = AlmacenCelulosa;
                    AlmacenCelulosa = 0;
                }
                else
                {
                    AlmacenCelulosa -= MasaEmpaquetada;
                    MasaProducto = MasaEmpaquetada;
                }

                double MasaBolsa = 0;
                while (MasaProducto > 13)
                {
                    NumerosAleatorios.Distribuciones.Uniform(13, 2, ref  MasaBolsa);
                    MasaProducto -= MasaBolsa;
                    ProductoNetoProducido += MasaBolsa;
                    TotalBolsas++;
                }

                AlmacenCelulosa += MasaProducto;
            }


        }
    }
}
