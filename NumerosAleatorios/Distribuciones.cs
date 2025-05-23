﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosAleatorios
{
    public class Distribuciones
    {
        #region CONTINUOUS Distributions.
        static public void Uniform(double a, double b, ref double x)
        {
            double aux = a;
            a = Math.Min(aux, b);
            b = Math.Max(aux, b);

            double u = 0;
            Generador.G(ref u);

            x = a + (b - a) * u;
        }

        static public void Exponential(double ex, ref double x)
        {
            double u = 0;
            Generador.G(ref u);

            x = -ex * Math.Log(u);
        }

        static public void Normal(double m, double d, ref double x)
        {
            double sum = 0;
            for (int i = 0; i < 12; i++)
            {
                double u = 0;
                Generador.G(ref u);

                sum += u;
            }

            x = d * (sum - 6) + m;
        }
        #endregion

        #region DISCRETE Distributions
        static public void Binomial(double n, double p, ref double x)
        {
            x = 0;
            for (int i = 0; i < n; i++)
            {
                double u = 0;
                Generador.G(ref u);

                if (u <= p) x += 1;
            }

        }

        static public void Poisson(double a, ref double x)
        {
            double b = Math.Exp(-a);
            double inc = 0;
            double p = 1;
            do
            {
                double u = 0;
                Generador.G(ref u);

                p *= u;
                inc += 1;
            } while (p > b);

            x = inc;
        }

        public static int PoissonDistribution(double lambda)
        {
            double L = Math.Exp(-lambda);
            double p = 1.0;
            int k = 0;

            do
            {
                k++;
                double u = 0;
                Generador.G(ref u); // Generate a Uniform Random Number
                p *= u;
            }
            while (p > L);

            return k - 1;
        }
        #endregion
    }
}
