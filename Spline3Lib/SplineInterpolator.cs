using System;
using MathNet.Numerics.LinearAlgebra;

namespace Spline3Lib
{
    /*
     * Implements cubic spline interpolation
     */
    public class SplineInterpolator
    {
        private double[] h;

        private Tuple<double, double>[] nodes;

        private Spline[] splines;

        private int N { get { return splines.Length; } }
        
        /*
         * Default constructor
         * nodes - tuple <vC, f(vC)> to run interpolation on
         */
        public SplineInterpolator(Tuple<double, double>[] nodes)
        {
            // Initializing nodes
            this.nodes = nodes;

            // Initializing empty splines
            splines = new Spline[this.nodes.Length - 1];
            for (int i = 0; i < splines.Length; i++)
            {
                splines[i] = new Spline();
            }

            // Calculating h
            h = new double[N];
            for (int i = 0; i < N; i++)
            {
                h[i] = nodes[i + 1].Item1 - nodes[i].Item1;
            }
        }

        /*
         * Runs interpolation
         */
        public Spline[] Interpolate()
        {
            // Setting A and XL
            for (int i = 0; i < N; i++)
            {
                splines[i].XL = nodes[i].Item1;
                splines[i].A  = nodes[i].Item2;
            }

            // Setting C
            double[] c = CalculateC();
            for (int i = 0; i < N; i++)
            {
                splines[i].C = c[i];
            }

            // Setting B and D
            for (int i = 0; i < N - 1; i++)
            {
                splines[i].B = ((nodes[i + 1].Item2 - nodes[i].Item2) / (nodes[i + 1].Item1 - nodes[i].Item1)) -
                               (2 * splines[i].C + splines[i + 1].C) * ((nodes[i + 1].Item1 - nodes[i].Item1) / 3);
                splines[i].D = (splines[i + 1].C - splines[i].C) / 
                                (3 * (nodes[i + 1].Item1 - nodes[i].Item1));
            }
            splines[N - 1].B = ((nodes[N].Item2 - nodes[N - 1].Item2)/ h[N - 1]) - 
                               ((2.0/3.0) * h[N - 1] * splines[N - 1].C);
            splines[N - 1].D = -1.0 * (splines[N - 1].C / (3.0 * h[N - 1]));

            // Returning
            return splines;
        }

        private double[] CalculateC()
        {
            // Calculating C system coefficients
            double[,] A = new double[N, N];
            A[0, 0] = 1;
            A[N - 1, N - 1] = 1;
            for (int i = 1; i < N - 1; i++)
            {
                A[i, i - 1] = h[i];
                A[i, i]     = 2.0 * (h[i] + h[i + 1]);
                A[i, i + 1] = h[i + 1];
            }

            // Calculating free members of system
            double[] b = new double[N];
            for (int i = 1; i < N - 1; i++)
            {
                b[i] = 3.0 * 
                (((nodes[i + 1].Item2 - nodes[i].Item2) / h[i]) - ((nodes[i].Item2 - nodes[i - 1].Item2) / h[i - 1]));
            }

            // Solving system
            var mA = Matrix<double>.Build.DenseOfArray(A);
            var vB = Vector<double>.Build.DenseOfArray(b);
            var vC = mA.Solve(vB);

            // Returning
            return vC.ToArray();
        }
    }
}
