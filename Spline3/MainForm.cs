using System;
using System.Windows.Forms;
using GuiTemplate.service;

namespace GuiTemplate
{
    public partial class MainForm : Form
    {
        private Func<double, double> originalFunction;

        private Func<double, double> interpolationFunction;

        private Tuple<double, double>[] nodes;

        public MainForm()
        {
            InitializeComponent();

            // Initializing chart scale data grid view
            UiService.InitializeChartScaleDataGridView(chartDataGridView);

            // Adding default chart area to main chart
            ChartService.AddDefaultChartAreaToChart(chartMain);
        }

        private void scaleButton_Click(object sender, EventArgs e)
        {
            // Cursor wait
            Cursor.Current = Cursors.WaitCursor;

            // Checking for existing chart areas
            if (chartMain.ChartAreas.Count == 0)
            {
                Cursor.Current = Cursors.Default;
                return;
            }

            // Updating scale
            try
            {
                ChartService.UpdateChartAreaScaleProperties(chartMain.ChartAreas[0], chartDataGridView);
            }
            catch
            {
                MessageBox.Show("Something went wrong during setting chart properties, please check them.",
                                "Oops!",
                                MessageBoxButtons.OK);
                Cursor.Current = Cursors.Default;
                return;
            }

            // Cursor regular
            Cursor.Current = Cursors.Default;
        }

        private async void interpolationButton_Click(object sender, EventArgs e)
        {
            // Cursor wait
            Cursor.Current = Cursors.WaitCursor;

            // Configuring chart area
            try
            {
                ChartService.ConfigureChartArea(chartMain.ChartAreas[0], chartDataGridView);
            }
            catch
            {
                MessageBox.Show("Something went wrong during setting chart properties, please check them.",
                                "Oops!",
                                MessageBoxButtons.OK);
                Cursor.Current = Cursors.Default;
                return;
            }

            // Getting nodes
            if (interpolationDataGridView.Rows.Count <= 2)
            {
                MessageBox.Show("Not enough nodes for interpolation. Add more nodes!", 
                                "Oops!", MessageBoxButtons.OK);
                Cursor.Current = Cursors.Default;
                return;
            }
            nodes = new Tuple<double, double>[interpolationDataGridView.Rows.Count];
            try
            {
                for (int i = 0; i < nodes.Length; i++)
                {
                    nodes[i] = new Tuple<double, double>(Convert.ToDouble(interpolationDataGridView.Rows[i].Cells[0].Value),
                                                         Convert.ToDouble(interpolationDataGridView.Rows[i].Cells[1].Value));
                }
            }
            catch
            {
                MessageBox.Show("Something went wrong during setting nodes, please check them.",
                                "Oops!", MessageBoxButtons.OK);
                Cursor.Current = Cursors.Default;
                return;
            }

            // Interpolating
            interpolationFunction = InterpolationService.Interpolate(nodes);

            // Cursor regular
            Cursor.Current = Cursors.Default;
        }

        private void addNodeButton_Click(object sender, EventArgs e)
        {
            interpolationDataGridView.Rows.Add(new DataGridViewRow());
        }

        private void deleteNodeButton_Click(object sender, EventArgs e)
        {
            if (interpolationDataGridView.Rows.Count == 0)
            {
                return;
            }

            interpolationDataGridView.Rows.RemoveAt(interpolationDataGridView.Rows.Count - 1);
        }

        private void fbutton_Click(object sender, EventArgs e)
        {
            // Cursor wait
            Cursor.Current = Cursors.WaitCursor;

            // Getting generation parameters
            double fMin = 0;
            double fMax = 0;
            int fCount  = 0;
            try
            {
                fMin   = Convert.ToDouble(fMinTextBox.Text);
                fMax   = Convert.ToDouble(fMaxTextBox.Text);
                fCount = Convert.ToInt32(fCountTextBox.Text);
                UiService.ValidateInterpolationNodesGenerationParametes(fMin, fMax);
            }
            catch
            {
                MessageBox.Show("Something went wrong during setting generation interpolation nodes properties.",
                                "Oops!",
                                MessageBoxButtons.OK);
                Cursor.Current = Cursors.Default;
                return;
            }

            // Getting function
            try
            {
                originalFunction = FunctionService.CreateFunctionFromString(fTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Something went wrong during evaluation entered function. Check your expression.",
                                "Oops!",
                                MessageBoxButtons.OK);
                Cursor.Current = Cursors.Default;
                return;
            }

            // Generating table
            var t = FunctionService.GenerateFunctionTable(originalFunction, fMin, fMax, fCount);

            // Displaying
            interpolationDataGridView.Rows.Clear();
            DataGridViewRow current;
            foreach (var node in t)
            {
                current = new DataGridViewRow();
                interpolationDataGridView.Rows.Add(current);
                interpolationDataGridView.Rows[interpolationDataGridView.Rows.Count - 1].Cells[0].Value = node.Item1;
                interpolationDataGridView.Rows[interpolationDataGridView.Rows.Count - 1].Cells[1].Value = node.Item2;
            }

            // Changing cursor back
            Cursor.Current = Cursors.Default;
        }

        private void buttonPlotSpline_Click(object sender, EventArgs e)
        {
            if (interpolationFunction != null)
            {
                ChartService.UpdateChartAreaScaleProperties(chartMain.ChartAreas[0], chartDataGridView);
                PlotService.PlotFunctionOnChartWithPPS(interpolationFunction, chartMain, (int)ppsNumericUpDown.Value);
            }
        }

        private void buttonPlotOriginal_Click(object sender, EventArgs e)
        {
            if (originalFunction != null)
            {
                ChartService.UpdateChartAreaScaleProperties(chartMain.ChartAreas[0], chartDataGridView);
                PlotService.PlotFunctionOnChartWithPPS(originalFunction, chartMain, (int)ppsNumericUpDown.Value);
            }
        }

        private void buttonPlotNodes_Click(object sender, EventArgs e)
        {
            if (nodes != null)
            {
                ChartService.UpdateChartAreaScaleProperties(chartMain.ChartAreas[0], chartDataGridView);
                PlotService.PlotPointsOnChart(nodes, chartMain);
            }
        }

        private void buttonClearChart_Click(object sender, EventArgs e)
        {
            chartMain.Series.Clear();
        }
    }
}
