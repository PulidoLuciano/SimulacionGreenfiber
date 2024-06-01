using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosAleatorios
{
    public static class Generador
    {
        public static List<double> ParteCentralCuadrado(int digitos, int semilla, int cantidad)
        {
            List<double> randomNumbers = new List<double>();

            for (int i = 0; i < cantidad; i++)
            {
                double x = Math.Pow(semilla, 2);
                string cadenaX = x.ToString();
                if(cadenaX.Length < digitos) break;
                if ((cadenaX.Length - digitos) % 2 != 0)
                {
                    x = x * 10;
                    cadenaX = x.ToString();
                }
                cadenaX = cadenaX.Substring((cadenaX.Length - 1) / 2 - (digitos - 1) / 2, digitos);
                semilla = int.Parse(cadenaX);
                randomNumbers.Add(semilla / Math.Pow(10, digitos));
                if (semilla == 0) break;
            }

            return randomNumbers;
        }

        public static List<double> Lehmer(int semilla, int t, int cantidad)
        {
            List<double> randomNumbers = new List<double>();
            int n = semilla.ToString().Length;
            int k = t.ToString().Length;

            if (k >= n)
                throw new ArgumentException("La cantidad de dígitos de t debe ser menor que la cantidad de dígitos de la semilla");

            for (int i = 0; i < cantidad; i++)
            {
                string aux = (semilla * t).ToString();
                int comienzo = int.Parse(aux.Substring(0, k));
                int final = int.Parse(aux.Substring(k));
                semilla = final - comienzo;
                randomNumbers.Add(semilla / Math.Pow(10, semilla.ToString().Length));
                if (semilla == 0) break;
            }

            return randomNumbers;
        }

        public static List<double> CongruencialAditivo(int precision, int cantidad, int m, params int[] ns)
        {
            List<double> randomNumbers = new List<double>();
            Queue<int> historico = new Queue<int>(ns);

            int n = historico.Last();
            for (int i = 0; i < cantidad; i++)
            {
                n = (historico.Dequeue() + n) % m;
                historico.Enqueue(n);
                randomNumbers.Add(double.Parse(((double)n / m).ToString().Substring(0, precision + 2)));
            }

            return randomNumbers;
        }

        public static List<double> CongruencialMultiplicativo(int precision, int cantidad, int m, int a, int n)
        {
            List<double> randomNumbers = new List<double>();

            for (int i = 0; i < cantidad; i++)
            {
                n = (a * n) % m;
                randomNumbers.Add(double.Parse(((double)n / m).ToString().Substring(0, precision + 2)));
            }

            return randomNumbers;
        }

        public static List<double> CongruencialMixto(int precision, int cantidad, int m, int a, int c, int n)
        {
            List<double> randomNumbers = new List<double>();

            for (int i = 0; i < cantidad; i++)
            {
                n = (a * n + c) % m;
                randomNumbers.Add(double.Parse(((double)n / m).ToString().Substring(0, precision + 2)));
            }

            return randomNumbers;
        }

        static int seed()
        {
            Random rand = new Random();
            int u = rand.Next(10000, 15000);
            return u;
        }

        public static void G(ref double u)
        {
            List<double> numeros;
            do
            {
                numeros = ParteCentralCuadrado(3, seed(), 10);
            } while (Tester.Promedios(numeros,1.96));
            u = numeros[0];
        }
    }
}
