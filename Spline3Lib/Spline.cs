using System;

namespace Spline3Lib
{
    /*
     * Represents cubic (^3) interpolation spline.
     */ 
    public class Spline
    {
        private double xl;

        private double a;

        private double b;

        private double c;

        private double d;

        /*
         * All args constructor
         * a - 0 coef
         * b - 1 coef
         * c - 2 coef
         * d - 3 coef
         * xl - x of left segment point
         */ 
        public Spline(double xl, double a, double b, double c, double d)
        {
            this.xl = xl;
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        /*
         * Calculates spline value for given x
         */
        public double F(double x)
        {
            return a + b * (x - xl) + c * Math.Pow(x - xl, 2) + d * Math.Pow(x - xl, 3);
        }
    }
}
