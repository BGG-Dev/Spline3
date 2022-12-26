using System;
using MathNet.Numerics.LinearAlgebra;

namespace Spline3Lib
{
    /*
     * Implements cubic spline interpolation
     */
    public class SplineInterpolator
    {
        private int N;

        private double[] hx;

        private double[] hy;

        public Func<double, double> Interpolate(Tuple<double, double>[] nodes)
        {
            // Define N as spline count. Spline count = node count - 1
            N = nodes.Length - 1;

            // Creating arrays
            hx         = new double[N];
            hy         = new double[N];
            double[] b = new double[N];
            double[] c;
            double[] d = new double[N];

            // Initializing hx
            for (int i = 0; i < N; i++) // [0; n - 1] => [1; n]
            {
                hx[i] = nodes[i + 1].Item1 - nodes[i].Item1;
                hy[i] = nodes[i + 1].Item2 - nodes[i].Item2;
            }

            // Calculating c
            c = CalculateC();

            // Calculating b and d
            for (int i = 0; i < N - 1; i++) // [0; n - 2] => [1; n - 1]
            {
                b[i] = (hy[i] / hx[i]) - ((hx[i] / 3.0) * (c[i + 1] + 2 * c[i]));
                d[i] = (c[i + 1] - c[i]) / (3.0 * hx[i]);
            }
            b[N - 1] = (hy[N - 1] / hx[N - 1]) - ((2.0 / 3.0) * hx[N - 1] * c[N - 1]);
            d[N - 1] = -1.0 * (c[N - 1] / (3.0 * hx[N - 1]));

            // Creating spline array
            Spline[] splines = new Spline[N];
            for (int i = 0; i < N; i++)
            {
                splines[i] = new Spline(nodes[i].Item1, nodes[i].Item2, b[i], c[i], d[i]);
            }

            // Return spline function;
            return x =>
            {
                if (x < nodes[0].Item1)
                {
                    return splines[0].F(x);
                }

                for (int i = 0; i < nodes.Length - 1; i++)
                {
                    if (nodes[i].Item1 <= x && x <= nodes[i + 1].Item1)
                    {
                        return splines[i].F(x);
                    }
                }

                return splines[splines.Length - 1].F(x);
            };
        }

        private double[] CalculateC()
        {
            // Allocating matrix
            double[,] matrixCoefficients = new double[N + 1, N + 1];

            // Fake coefficients
            matrixCoefficients[0, 0] = 1; // [0, 0] => [1, 1]
            matrixCoefficients[N, N] = 1; // [n, n] => [n + 1, n + 1]

            // Calculating rest
            for (int i = 1; i < N; i++) // [1; n - 1] => [2; n]
            {
                matrixCoefficients[i, i - 1] = hx[i - 1];
                matrixCoefficients[i, i] = 2.0 * (hx[i - 1] + hx[i]);
                matrixCoefficients[i, i + 1] = hx[i];
            }

            // Calculating free coefficients
            double[] freeCoefficients = new double[N + 1];
            for (int i = 1; i < N; i++) // [1; n - 1] => [2; n]
            {
                freeCoefficients[i] = 3.0 * ((hy[i] / hx[i]) - (hy[i - 1] / hx[i - 1]));
            }

            // Solving system
            var A = Matrix<double>.Build.DenseOfArray(matrixCoefficients);
            var B = Vector<double>.Build.DenseOfArray(freeCoefficients);
            var C = A.Solve(B);

            // Returning
            double[] result = new double[N];
            for (int i = 0; i < N; i++)
            {
                result[i] = C.At(i);
            }
            return result;
        }
    }
}
