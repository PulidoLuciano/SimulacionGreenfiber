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

        //
        public double MasaNominalRecolectada { get; set; } // MOSTRAR

        // Resultados totales.
        public double ProductoNetoProducido { get; set; }  // MOSTRAR
        public double TotalBolsas { get; set; }  // MOSTRAR
        public double PapelNetoReciclado { get; set; }  // MOSTRAR
        public double PotenciaTotal { get; set; }  // MOSTRAR
        public double ArbolesSalvados { get; set; }  // MOSTRAR
        public double ConsumoBorax { get; set; }  // MOSTRAR 
        public double ConsumoAcidoBorico { get; set; } // MOSTRAR

        // Cantidades segun nivel de basura /// ESTO LO BORRARIA PORQUE SIEMPRE SERAN ENTRE LOS MISMOS VALORES. Siempre sera mayor el intermedio que el resto.
        public double PapelEscaso { get; set; }
        public double PapelIntermedio { get; set; }
        public double PapelExcesivo { get; set; }

        // Cantidad en almacenes. Dinamicos e interdependientes a lo largo de la simulacion.
        public double AlmacenRecolectado { get; set; }
        public double AlmacenPapel { get; set; }
        public double AlmacenBasura { get; set; }
        public double AlmacenCelulosa { get; set; }

        

        // Lo que hubiera producido cada maquina;
        public double ProduccionNominalTrituradora { get; set; } // MOSTRAR
        public double ProduccionNominalRefinadora{ get; set; } // MOSTRAR
        public double ProduccionNominalEmpaquetadora { get; set; } // MOSTRAR

        // Lo que hubiera producido cada maquina;
        public double ProduccionRealTrituradora { get; set; } // MOSTRAR
        public double ProduccionRealRefinadora { get; set; } // MOSTRAR
        public double ProduccionRealEmpaquetadora { get; set; } // MOSTRAR

        public double DesperdicioTrituradoraV2
        {
            get { return ProduccionNominalTrituradora - ProduccionRealTrituradora; }
        }

        public double DesperdicioRefinadoraV2
        {
            get { return ProduccionNominalRefinadora - ProduccionRealRefinadora; }
        }

        public double DesperdicioEmpaquetadoraV2
        {
            get { return ProduccionNominalEmpaquetadora - ProduccionRealEmpaquetadora; }
        }

        public void iniciar(int HorasJornada, double MinPapel, double MaxPapel)
        {
            reiniciar();
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
                    MasaNominalRecolectada += MasaRecolectada;

                    AlmacenRecolectado += MasaRecolectada;

                    // ----- TRITURACION -----
                    double MasaTriturada = 0;
                    NumerosAleatorios.Distribuciones.Normal(_maquinaTrituradora.CapacidadPromedio, 60, ref MasaTriturada);
                    ProduccionNominalTrituradora += MasaTriturada;

                    if(MasaTriturada > AlmacenRecolectado)
                    {
                        //DesperdicioTrituradora += MasaTriturada - AlmacenRecolectado;
                        MasaTriturada = AlmacenRecolectado;
                        AlmacenRecolectado = 0;
                    }
                    else
                    {
                        AlmacenRecolectado -= MasaTriturada;
                    }

                    ProduccionRealTrituradora += MasaTriturada;

                    // ----- LIMPIEZA -----
                    NumerosAleatorios.Generador.G(ref u);

                    double porcPapel = 0;
                    

                    if (u <= 0.2)
                    {
                        

                        NumerosAleatorios.Generador.G(ref u);

                        NumerosAleatorios.Distribuciones.Uniform(0.90, 0.98, ref porcPapel);

                        PapelEscaso += MasaTriturada;

                    }
                    else if (u <= 0.95)
                    {
                        

                        NumerosAleatorios.Distribuciones.Normal(0.7,0.08, ref porcPapel);

                        PapelIntermedio += MasaTriturada;
                    }
                    else
                    {
                        

                        NumerosAleatorios.Distribuciones.Normal(0.5, 0.05, ref porcPapel);

                        PapelExcesivo += MasaTriturada;
                    }

                    double Papel = MasaTriturada * porcPapel;
                    double Basura = MasaTriturada * (1 - porcPapel);

                    AlmacenPapel += Papel;
                    AlmacenBasura += Basura;

                    // ----- REFINACION -----
                    double MasaFibra = 0;
                    NumerosAleatorios.Distribuciones.Normal(_maquinaRefinadora.CapacidadPromedio, 60, ref MasaFibra);
                    ProduccionNominalRefinadora += MasaFibra;

                    if (MasaFibra > AlmacenPapel)
                    {
                        //DesperdicioRefinadora += MasaFibra - AlmacenPapel;
                        MasaFibra = AlmacenPapel;
                        AlmacenPapel = 0;
                    }
                    else
                    {
                        AlmacenPapel -= MasaFibra;
                    }

                    ProduccionRealRefinadora += MasaFibra;

                    
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
                    ProduccionNominalEmpaquetadora += MasaEmpaquetada;

                    if (MasaEmpaquetada > AlmacenCelulosa)
                    {
                        //DesperdicioEmpaquetadora += MasaEmpaquetada - AlmacenCelulosa;
                        MasaEmpaquetada = AlmacenCelulosa;
                        AlmacenCelulosa = 0;
                    }
                    else
                    {
                        AlmacenCelulosa -= MasaEmpaquetada;
                    }
                   
                    ProduccionRealEmpaquetadora += MasaEmpaquetada;

                    double MasaBolsa = 0;

                    while (MasaEmpaquetada > 15)
                    {
                        NumerosAleatorios.Distribuciones.Uniform(13, 15, ref  MasaBolsa);
                        MasaEmpaquetada -= MasaBolsa;                       
                        ProductoNetoProducido += MasaBolsa;
                        TotalBolsas++;
                    }
                    if (MasaEmpaquetada > 13)
                    {
                        ProductoNetoProducido += MasaEmpaquetada;
                        TotalBolsas++;
                        MasaEmpaquetada = 0;
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
        void reiniciar()
        {
            ProductoNetoProducido = 0;// MOSTRAR
            TotalBolsas = 0;// MOSTRAR
            PapelNetoReciclado = 0;// MOSTRAR
            PotenciaTotal = 0;// MOSTRAR
            ArbolesSalvados = 0;// MOSTRAR
            ConsumoBorax = 0;// MOSTRAR 
            ConsumoAcidoBorico = 0;// MOSTRAR
            MasaNominalRecolectada = 0;

            // Cantidades segun nivel de basura /// ESTO LO BORRARIA PORQUE SIEMPRE SERAN ENTRE LOS MISMOS VALORES. Siempre sera mayor el intermedio que el resto.
            PapelEscaso = 0;
            PapelIntermedio = 0;
            PapelExcesivo = 0;

            // Cantidad en almacenes. Dinamicos e interdependientes a lo largo de la simulacion.
            AlmacenRecolectado = 0;
            AlmacenPapel = 0;
            AlmacenBasura = 0;         
            AlmacenCelulosa = 0;
                      
            // Lo que hubiera producido cada maquina;
            ProduccionNominalTrituradora = 0;// MOSTRAR
            ProduccionNominalRefinadora = 0;// MOSTRAR
            ProduccionNominalEmpaquetadora = 0;// MOSTRAR

            // Lo que hubiera producido cada maquina;
            ProduccionRealTrituradora = 0;// MOSTRAR
            ProduccionRealRefinadora = 0;// MOSTRAR
            ProduccionRealEmpaquetadora = 0;// MOSTRAR
        }
    }
}
