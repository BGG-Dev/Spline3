using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GuiTemplate
{
    internal static class ChartService
    {
        public static void AddDefaultChartAreaToChart(Chart chart)
        {
            // Creating new chart area
            ChartArea area = new ChartArea("MainArea");

            // Adding new chart area
            chart.ChartAreas.Add(area);
        }

        public static void ConfigureChartArea(ChartArea area, DataGridView scaleDataSource)
        {
            // Finalizing X
            area.AxisX.Crossing = 0;
            area.AxisX.LineWidth = 5;
            area.AxisX.Title = "X";

            // Finalizing Y
            area.AxisY.Crossing = 0;
            area.AxisY.LineWidth = 5;
            area.AxisY.Title = "Y";
        }

        public static void UpdateChartAreaScaleProperties(ChartArea area, DataGridView dataSource)
        {
            // Getting chart properties
            Tuple<double[], double[]> properties = GenerateChartAreaScaleProperteisFromDataGridView(dataSource);
            
            // Validating
            if (!ValidateChartProperties(properties.Item1, properties.Item2))
            {
                throw new Exception();
            }

            // Setting min, max, interval
            area.AxisX.Minimum = properties.Item1[0];
            area.AxisX.Maximum = properties.Item1[1];
            area.AxisX.Interval = properties.Item1[2];
            area.AxisY.Minimum = properties.Item2[0];
            area.AxisY.Maximum = properties.Item2[1];
            area.AxisY.Interval = properties.Item2[2];
        }

        private static Tuple<double[], double[]> GenerateChartAreaScaleProperteisFromDataGridView(DataGridView dataSource)
        {
            // Creating properties holders
            double[] xProperteis = new double[3];
            double[] yProperteis = new double[3];

            // Getting
            for (int i = 0; i < 3; i++)
            {
                xProperteis[i] = Convert.ToDouble(dataSource.Rows[i].Cells[0].Value);
                yProperteis[i] = Convert.ToDouble(dataSource.Rows[i].Cells[1].Value);
            }

            // Return tuple of properties
            return new Tuple<double[], double[]>(xProperteis, yProperteis);
        }

        private static bool ValidateChartProperties(double[] xProperteis, double[] yProperties)
        {
            return ValidateAxisProperties(xProperteis) && ValidateAxisProperties(yProperties);
        }

        private static bool ValidateAxisProperties(double[] asixProperties)
        {
            return (asixProperties[1] > asixProperties[0]) &&
                   (asixProperties[1] - asixProperties[0] > asixProperties[2]);
        }
    }
}
