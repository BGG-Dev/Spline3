using Microsoft.VisualStudio.TestTools.UnitTesting;
using Spline3Lib;

namespace Spline3LibTest
{
    /*
     * Test class for Spline
     */
    [TestClass]
    public class SplineTest
    {
        [TestMethod]
        public void CalculateTest()
        {
            // Creating spline
            Spline s = new Spline(9, 4, 3, 2, 1);

            // Calculating
            double result = s.F(10);

            // Asserting
            Assert.AreEqual(10, result);
        }
    }
}
