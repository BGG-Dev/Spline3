using System;
using MathNet.Numerics.LinearAlgebra;

namespace Spline3Lib
{
    /*
     * Implements cubic spline interpolation
     */
    public class SplineInterpolator
    {
        private double[] hX;

        private double[] hY;

        private Tuple<double, double>[] nodes;

        private double[] b;

        private double[] c;

        private double[] d;

        private int N { get { return nodes.Length - 1; } }
        
        /*
         * Default constructor
         * nodes - tuple <vC, f(vC)> to run interpolation on
         */
        public SplineInterpolator(Tuple<double, double>[] nodes)
        {
            // Initializing nodes
            this.nodes = nodes;

            // Initializing empty coefficients
            b = new double[N];
            d = new double[N];

            // Calculating hX and hY
            hX = new double[N];
            hY = new double[N];
            for (int i = 0; i < N; i++)
            {
                hX[i] = nodes[i + 1].Item1 - nodes[i].Item1;
                hY[i] = nodes[i + 1].Item2 - nodes[i].Item2;
            }
        }

        /*
         * Runs interpolation
         */
        public Spline[] Interpolate()
        {
            // Calculating C
            c = CalculateC();

            // Calculating B and D
            for (int i = 0; i < N - 1; i++)
            {
                b[i] = ((hY[i] / hX[i]) - (2 * c[i] + c[i + 1]) * hX[i] / 3.0);
                d[i] = (c[i + 1] - c[i]) / (3 * hX[i]);
            }
            b[N - 1] = (hY[N - 1] / hX[N - 1]) - ((2.0/3.0) * hX[N - 1] * c[N - 1]);
            d[N - 1] = -1.0 * (c[N - 1] / (3.0 * hX[N - 1]));

            // Creating splines
            Spline[] splines = new Spline[N];
            for (int i = 0; i < N; i++)
            {
                splines[i] = new Spline(nodes[i].Item1, nodes[i].Item2, b[i], c[i], d[i]);
            }

            // Returning
            return splines;
        }

        private double[] CalculateC()
        {
            // Calculating C system coefficients
            double[,] matrixCoefficients = new double[N, N];
            matrixCoefficients[0, 0] = 1;
            matrixCoefficients[N - 1, N - 1] = 1;
            for (int i = 1; i < N - 1; i++)
            {
                matrixCoefficients[i, i - 1] = hX[i];
                matrixCoefficients[i, i]     = 2.0 * (hX[i] + hX[i + 1]);
                matrixCoefficients[i, i + 1] = hX[i + 1];
            }

            // Calculating freeCoefficients members of system
            double[] freeCoefficients = new double[N];
            for (int i = 1; i < N - 1; i++)
            {
                freeCoefficients[i] = 3.0 * ((hY[i] / hX[i]) - ((hY[i - 1]) / hX[i - 1]));
            }

            // Solving system
            var mA = Matrix<double>.Build.DenseOfArray(matrixCoefficients);
            var vB = Vector<double>.Build.DenseOfArray(freeCoefficients);
            var vC = mA.Solve(vB);

            // Returning
            return vC.ToArray();
        }
    }
}
