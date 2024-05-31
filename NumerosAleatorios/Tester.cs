using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosAleatorios
{
    public static class Tester
    {
        public static bool Promedios(List<double> numeros, double estadistico)
        {
            double promedio = numeros.Average();
            double zCero = ((promedio - 0.5) * Math.Sqrt(numeros.Count)) / Math.Sqrt(1.0 / 12.0);
            return Math.Abs(zCero) < estadistico;
        }

        public static bool Frecuencia(List<double> numeros, int cantidadIntervalos, double estadistico)
        {
            double frecuenciaEsperada = (double)numeros.Count / cantidadIntervalos;
            double sumatoria = 0;
            for (int i = 1; i <= cantidadIntervalos; i++)
            {
                double intervaloSuperior = (double)1 / cantidadIntervalos * i;
                double intervaloInferior = (double)1 / cantidadIntervalos * (i - 1);
                int frecuenciaIntervalo = numeros.FindAll(x => x < intervaloSuperior && x >= intervaloInferior).Count;
                sumatoria += Math.Pow(frecuenciaIntervalo - frecuenciaEsperada, 2);
            }
            sumatoria *= (double)cantidadIntervalos / numeros.Count;
            return sumatoria < estadistico;
        }

        public static bool Serie(List<double> numeros, int cantidadIntervalos, double estadistico)
        {
            if (numeros.Count % 2 != 0) throw new ArgumentException("La cantidad de números aleatorios generados debe ser par");
            double frecuenciaEsperada = (double)numeros.Count / 2 / Math.Pow(cantidadIntervalos, 2);
            int[,] intervalos = new int[cantidadIntervalos, cantidadIntervalos];
            for (int i = 0; i < numeros.Count; i = i + 2)
            {
                int columna = (int)Math.Truncate(numeros[i + 1] / (1.0 / cantidadIntervalos));
                int fila = cantidadIntervalos - 1 - (int)Math.Truncate(numeros[i] / (1.0 / cantidadIntervalos));
                intervalos[fila, columna]++;
            }
            double sumatoria = 0;
            foreach (int frecuencia in intervalos)
            {
                sumatoria += Math.Pow(frecuencia - frecuenciaEsperada, 2);
            }
            sumatoria *= (double)Math.Pow(cantidadIntervalos, 2) / (numeros.Count / 2.0);
            return sumatoria < estadistico;
        }

        public static bool KS(List<double> numeros, double estadistico)
        {
            numeros.Sort();
            for (int i = 1; i <= numeros.Count; i++)
            {
                numeros[i - 1] = (double)i / numeros.Count - numeros[i - 1];
            }
            double d = numeros.Max();
            return d < estadistico;
        }

        public static bool Corrida(List<double> numeros, double estadistico)
        {
            string secuenciaBinaria = "";

            numeros.ForEach(numero =>
            {
                if (numero <= 0.5) secuenciaBinaria += "0";
                else secuenciaBinaria += "1";
            });

            List<int> frecuencias = new List<int>();
            int contador = 1;
            for (int i = 1; i < numeros.Count; i++)
            {
                if (secuenciaBinaria[i] == secuenciaBinaria[i - 1])
                {
                    contador++;
                }
                else
                {
                    while (contador > frecuencias.Count)
                    {
                        frecuencias.Add(0);
                    }
                    frecuencias[contador - 1]++;
                    contador = 1;
                }
            }
            frecuencias[contador - 1]++;

            List<double> frecuenciasEsperadas = new List<double>();
            for (int i = 0; i < frecuencias.Count; i++)
            {
                frecuenciasEsperadas.Add((numeros.Count - (i + 1) + 3) / Math.Pow(2, (i + 1) + 1));
            }

            double sumatoria = 0;
            for (int i = 0; i < frecuencias.Count; i++)
            {
                sumatoria += Math.Pow(frecuencias[i] - frecuenciasEsperadas[i], 2) / frecuenciasEsperadas[i];
            }

            return sumatoria < estadistico;
        }
    }
}
