using GuiTemplate.service;
using System;
using System.Windows.Forms.DataVisualization.Charting;

namespace GuiTemplate
{
    static internal class PlotService
    {   
        public static void PlotFunctionOnChartWithPPS(Func<double, double> f,
                                                      Chart chart, int pps)
        {
            // Generating points
            Tuple<double, double>[] fTable = FunctionService.GenerateFunctionTable(f,
                                                                                   chart.ChartAreas[0].AxisX.Minimum,
                                                                                   chart.ChartAreas[0].AxisX.Maximum,
                                                                                   pps);
            // Creating series
            Series s = new Series();
            foreach (var item in fTable)
            {
                s.Points.AddXY(item.Item1, item.Item2);
            }
            s.ChartType = SeriesChartType.Line;
            s.BorderWidth = 3;

            // Adding
            chart.Series.Add(s);
        }

        public static void PlotPointsOnChart(Tuple<double, double>[] points, Chart chart)
        {
            // Creating series
            Series s = new Series();
            foreach (var item in points)
            {
                s.Points.AddXY(item.Item1, item.Item2);
            }
            s.ChartType = SeriesChartType.Point;
            s.MarkerSize = 15;
            s.MarkerStyle = MarkerStyle.Circle;

            // Adding
            chart.Series.Add(s);
        }
    }
}
