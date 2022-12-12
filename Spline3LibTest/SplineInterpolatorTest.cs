using Microsoft.VisualStudio.TestTools.UnitTesting;
using Spline3Lib;
using System;

namespace Spline3LibTest
{
    /*
     * Test class for SplineInterpolator
     */
    [TestClass]
    public class SplineInterpolatorTest
    {
        private Tuple<double, double>[] nodes;

        public SplineInterpolatorTest() 
        {
            // Creating nodes
            nodes = new Tuple<double, double>[7];
            nodes[0] = new Tuple<double, double>(-1.5, -0.7);
            nodes[1] = new Tuple<double, double>(-1.0, 0.0);
            nodes[2] = new Tuple<double, double>(-0.5, 0.7);
            nodes[3] = new Tuple<double, double>(0.0, 1.0);
            nodes[4] = new Tuple<double, double>(0.5, 0.7);
            nodes[5] = new Tuple<double, double>(1.0, 0.0);
            nodes[6] = new Tuple<double, double>(1.5, -0.7);
        }

        [TestMethod]
        public void CalculateCTest()
        {
            // Creating interpolator
            SplineInterpolator interpolator = new SplineInterpolator(nodes);

            // Calling CalculateC method
            PrivateObject obj = new PrivateObject(interpolator);
            double[] result = (double[])obj.Invoke("CalculateC");
            
            // Asserting
            double[] expected = new double[] { 0, 0.22, -0.92, -1.35, -0.86, 0 };
            for (int i = 0; i < 6; i++)
            {
                Assert.IsTrue(Math.Pow(expected[i] - result[i], 2) < 0.001);
            }
        }

        [TestMethod]
        public void InterpolateTest()
        {
            // Creating interpolator
            SplineInterpolator interpolator = new SplineInterpolator(nodes);

            // Running interpolation
            Spline[] result = interpolator.Interpolate();

            // Asserting
            double[] xl = new double[] { -1.5, -1.0, -0.5, 0.0, 0.5, 1.0 };
            double[] a = new double[] { -0.7, 0.0, 0.7, 1.0, 0.7, 0.0};
            double[] b = new double[] { 1.36, 1.48, 1.13, -0.007, -1.11, -1.4 };
            double[] c = new double[] { 0, 0.22, -0.92, -1.35, -0.86, 0 };
            double[] d = new double[] { 0.15, -0.76, -0.29, 0.33, 0.57, 0};
            PrivateObject obj;
            for (int i = 0; i < 6; i++)
            {
                obj = new PrivateObject(result[i]);
                Assert.AreEqual(xl[i], (double)obj.GetField("xl"));
                Assert.AreEqual(a[i], (double)obj.GetField("a"));
                Assert.IsTrue(Math.Pow(b[i] - (double)obj.GetField("b"), 2) < 0.001);
                Assert.IsTrue(Math.Pow(c[i] - (double)obj.GetField("c"), 2) < 0.001);
                Assert.IsTrue(Math.Pow(d[i] - (double)obj.GetField("d"), 2) < 0.001);
            }
        }
    }
}
