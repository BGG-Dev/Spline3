using Spline3Lib;
using System;

namespace GuiTemplate.service
{
    internal static class InterpolationService
    {
        public static Func<double, double> Interpolate(Tuple<double, double>[] nodes)
        {
            // Sorting
            Array.Sort(nodes, (a, b) =>
            {
                if (a.Item1 < b.Item1)
                {
                    return -1;
                }
                else if (a.Item1 > b.Item1)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            });

            // Interpolating
            SplineInterpolator interpolator = new SplineInterpolator();
            return interpolator.Interpolate(nodes);
        }
    }
}
