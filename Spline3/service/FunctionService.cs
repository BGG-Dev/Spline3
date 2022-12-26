using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GuiTemplate.service
{
    static internal class FunctionService
    {
        public static Func<double, double> CreateFunctionFromString(string fSrc)
        {
            var str = "x => " + fSrc;
            var options = ScriptOptions.Default.AddImports(new string[] { "System" });
            return CSharpScript.EvaluateAsync<Func<double, double>>(str, options).Result;
        }

        public static Tuple<double, double>[] GenerateFunctionTable(Func<double, double> f, 
                                                                    double xMin, double xMax, int pointCount)
        {
            LinkedList<Tuple<double, double>> result = new LinkedList<Tuple<double, double>>();
            double dx = Math.Abs(xMax - xMin) / pointCount;
            double x = xMin;
            for (int i = 0; i < pointCount; i++)
            {
                result.AddLast(new Tuple<double, double>(x, f.Invoke(x)));
                x += dx;
            }
            return result.ToArray();
        }
    }
}
