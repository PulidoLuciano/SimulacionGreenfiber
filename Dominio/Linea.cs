using Dominio.Maquinas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
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
        Trituradora _maquinaTrituradora = new Trituradora();
        Limpiadora _maquinaLimpiadora = new Limpiadora();
        Refinadora _maquinaRefinadora = new Refinadora();
        Empaquetadora _maquinaEmpaquetadora = new Empaquetadora();

        public Trituradora MaquinaTrituradora
        {
            get { return _maquinaTrituradora; }
            set{ _maquinaTrituradora = value; }
        }

        public Limpiadora MaquinaLimpiadora
        {
            get { return _maquinaLimpiadora; }
            set { _maquinaLimpiadora = value; }
        }

        public Refinadora MaquinaRefinadora
        {
            get { return _maquinaRefinadora; }
            set { _maquinaRefinadora = value; }
        }

        public Empaquetadora MaquinaEmpaquetadora
        {
            get { return _maquinaEmpaquetadora; }
            set { _maquinaEmpaquetadora = value; }
        }

        // Resultados totales.
        public double ProductoNetoProducido = 0;
        public double TotalBolsas = 0;
        public double PapelNetoReciclado = 0;
        public double PotenciaTotal = 0;
        public double ArbolesSalvados = 0;
        public double ConsumoBorax = 0;
        public double ConsumoAcidoBorico = 0;

        // Cantidades segun nivel de basura
        public double PapelEscaso = 0;
        public double PapelIntermedio = 0;
        public double PapelExcesivo = 0;

        // Cantidad en almacenes. Dinamicos e interdependientes a lo largo de la simulacion.
        public double AlmacenRecolectado = 0;
        public double AlmacenPapel = 0;
        public double AlmacenBasura = 0;
        public double AlmacenFibra = 0;
        public double AlmacenCelulosa = 0;

        // Pedidas de capacidades de maquinas en Kg. "Lo que podria haber producido"
        public double DesperdicioTrituradora = 0;
        public double DesperdicioRefinadora = 0;
        public double DesperdicioEmpaquetadora = 0;

        public void iniciar(int HorasJornada, double MinPapel, double MaxPapel)
        {
            try
            {
                if (MinPapel > MaxPapel || MinPapel <= 0 || MaxPapel <= 0)
                {
                    throw new Exception("Rango de papel inválido.");
                }
                if(HorasJornada < 1)
                {
                    throw new Exception("Horas de jornada inválida.");
                }

                int horas = HorasJornada;
                double u = 0;

                while (horas > 0)
                {
                    // ----- RECOLECCION -----
                    double MasaRecolectada = 0;
                    NumerosAleatorios.Distribuciones.Uniform(MinPapel, MaxPapel, ref MasaRecolectada);

                    AlmacenRecolectado += MasaRecolectada;

                    // ----- TRITURACION -----
                    double MasaTriturada = 0;
                    NumerosAleatorios.Distribuciones.Normal(_maquinaTrituradora.CapacidadPromedio, 60, ref MasaTriturada);

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
                    NumerosAleatorios.Distribuciones.Normal(_maquinaRefinadora.CapacidadPromedio, 60, ref MasaFibra);

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
                    NumerosAleatorios.Distribuciones.Normal(_maquinaEmpaquetadora.CapacidadPromedio, 60, ref MasaEmpaquetada);

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

                PotenciaTotal = HorasJornada * (_maquinaTrituradora.Potencia + _maquinaLimpiadora.Potencia + 
                    _maquinaRefinadora.Potencia + _maquinaEmpaquetadora.Potencia);
                ArbolesSalvados = 20 * (PapelNetoReciclado / 1000);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
