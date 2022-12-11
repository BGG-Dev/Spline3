using System;

namespace Spline3Lib
{
    /*
     * Represents cubic (^3) interpolation spline.
     */ 
    public class Spline
    {
        public double XL { get; set; }

        public double A { get; set; }

        public double B { get; set; }

        public double C { get; set; }

        public double D { get; set; }

        /*
         * No args constructor
         */
        public Spline() { }

        /*
         * All args constructor
         * a - 0 coef
         * b - 1 coef
         * c - 2 coef
         * d - 3 coef
         * xl - x of left segment point
         */ 
        public Spline(double a, double b, double c, double d, double xl)
        {
            XL = xl;
            A = a;
            B = b;
            C = c;
            D = d;
        }

        /*
         * Calculates spline value for given x
         */
        public double F(double x)
        {
            return A + B * (x - XL) + C * Math.Pow(x - XL, 2) + D * Math.Pow(x - XL, 3);
        }
    }
}
