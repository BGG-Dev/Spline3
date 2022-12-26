using System;
using System.Windows.Forms;

namespace GuiTemplate.service
{
    internal class UiService
    {
        public static void InitializeChartScaleDataGridView(DataGridView dataGridView)
        {
            // Creating min row
            var minRow = new DataGridViewRow();
            minRow.HeaderCell = new DataGridViewRowHeaderCell();
            minRow.HeaderCell.Value = "min:";
            
            // Creating max row
            var maxRow = new DataGridViewRow();
            maxRow.HeaderCell = new DataGridViewRowHeaderCell();
            maxRow.HeaderCell.Value = "max:";

            // Creating step row
            var stepRow = new DataGridViewRow();
            stepRow.HeaderCell = new DataGridViewRowHeaderCell();
            stepRow.HeaderCell.Value = "step:";

            // Adding
            dataGridView.Rows.Add(minRow);
            dataGridView.Rows.Add(maxRow);
            dataGridView.Rows.Add(stepRow);

            // Setting default values
            dataGridView.Rows[0].Cells[0].Value = -15;
            dataGridView.Rows[0].Cells[1].Value = -15;
            dataGridView.Rows[1].Cells[0].Value = 15;
            dataGridView.Rows[1].Cells[1].Value = 15;
            dataGridView.Rows[2].Cells[0].Value = 1;
            dataGridView.Rows[2].Cells[1].Value = 1;
        }

        public static void ValidateInterpolationNodesGenerationParametes(double fMin,
                                                                         double fMax)
        {
            if (fMax <= fMin)
            {
                throw new Exception();
            }
        }
    }
}
