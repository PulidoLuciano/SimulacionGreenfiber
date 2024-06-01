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


        double PapelNetoReciclado = 0;

        double PapelEscaso = 0;
        double PapelIntermedio = 0;
        double PapelExcesivo = 0;

        double AlmacenPapel = 0;
        double AlmacenBasura = 0;
        double AlmacenFibra = 0;
        double AlmacenCelulosa = 0;
        double AlmacenBolsas = 0;

        double PerdidaRefinadora = 0;
        
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
                NumerosAleatorios.Distribuciones.Poisson(MaquinaTrituradora.CapacidadPromedio, ref MasaFibra);

                if(MasaFibra > AlmacenPapel)
                {
                    PerdidaRefinadora += MasaFibra - AlmacenPapel;
                    AlmacenFibra += AlmacenPapel;
                    AlmacenPapel = 0;
                }
                else
                {
                    AlmacenPapel -= MasaFibra;
                    AlmacenFibra += MasaFibra;
                }

                NumerosAleatorios.Generador.G(ref u);

            }
        }
    }
}
