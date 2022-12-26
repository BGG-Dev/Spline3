namespace GuiTemplate
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.buttonClearChart = new System.Windows.Forms.Button();
            this.buttonPlotNodes = new System.Windows.Forms.Button();
            this.buttonPlotOriginal = new System.Windows.Forms.Button();
            this.buttonPlotSpline = new System.Windows.Forms.Button();
            this.interpolationButton = new System.Windows.Forms.Button();
            this.deleteNodeButton = new System.Windows.Forms.Button();
            this.ppsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.addNodeButton = new System.Windows.Forms.Button();
            this.scaleLabel = new System.Windows.Forms.Label();
            this.interpolationDataGridView = new System.Windows.Forms.DataGridView();
            this.NodeX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NodeY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interpolationTableLabel = new System.Windows.Forms.Label();
            this.ppsLabel = new System.Windows.Forms.Label();
            this.scaleButton = new System.Windows.Forms.Button();
            this.chartDataGridView = new System.Windows.Forms.DataGridView();
            this.chartMain = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.fPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.fMaxLabel = new System.Windows.Forms.Label();
            this.fMinLabel = new System.Windows.Forms.Label();
            this.fCountTextBox = new System.Windows.Forms.TextBox();
            this.fMaxTextBox = new System.Windows.Forms.TextBox();
            this.fMinTextBox = new System.Windows.Forms.TextBox();
            this.fbutton = new System.Windows.Forms.Button();
            this.fLabel = new System.Windows.Forms.Label();
            this.fTextBox = new System.Windows.Forms.TextBox();
            this.chartPanel = new System.Windows.Forms.Panel();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ppsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interpolationDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMain)).BeginInit();
            this.fPanel.SuspendLayout();
            this.chartPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.controlPanel.Controls.Add(this.buttonClearChart);
            this.controlPanel.Controls.Add(this.buttonPlotNodes);
            this.controlPanel.Controls.Add(this.buttonPlotOriginal);
            this.controlPanel.Controls.Add(this.buttonPlotSpline);
            this.controlPanel.Controls.Add(this.interpolationButton);
            this.controlPanel.Controls.Add(this.deleteNodeButton);
            this.controlPanel.Controls.Add(this.ppsNumericUpDown);
            this.controlPanel.Controls.Add(this.addNodeButton);
            this.controlPanel.Controls.Add(this.scaleLabel);
            this.controlPanel.Controls.Add(this.interpolationDataGridView);
            this.controlPanel.Controls.Add(this.interpolationTableLabel);
            this.controlPanel.Controls.Add(this.ppsLabel);
            this.controlPanel.Controls.Add(this.scaleButton);
            this.controlPanel.Controls.Add(this.chartDataGridView);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.controlPanel.Location = new System.Drawing.Point(0, 0);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(268, 820);
            this.controlPanel.TabIndex = 2;
            // 
            // buttonClearChart
            // 
            this.buttonClearChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearChart.Location = new System.Drawing.Point(162, 604);
            this.buttonClearChart.Name = "buttonClearChart";
            this.buttonClearChart.Size = new System.Drawing.Size(100, 32);
            this.buttonClearChart.TabIndex = 23;
            this.buttonClearChart.Text = "Clear plot";
            this.buttonClearChart.UseVisualStyleBackColor = true;
            this.buttonClearChart.Click += new System.EventHandler(this.buttonClearChart_Click);
            // 
            // buttonPlotNodes
            // 
            this.buttonPlotNodes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlotNodes.Location = new System.Drawing.Point(6, 566);
            this.buttonPlotNodes.Name = "buttonPlotNodes";
            this.buttonPlotNodes.Size = new System.Drawing.Size(256, 32);
            this.buttonPlotNodes.TabIndex = 22;
            this.buttonPlotNodes.Text = "Plot interpolation nodes";
            this.buttonPlotNodes.UseVisualStyleBackColor = true;
            this.buttonPlotNodes.Click += new System.EventHandler(this.buttonPlotNodes_Click);
            // 
            // buttonPlotOriginal
            // 
            this.buttonPlotOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlotOriginal.Location = new System.Drawing.Point(6, 527);
            this.buttonPlotOriginal.Name = "buttonPlotOriginal";
            this.buttonPlotOriginal.Size = new System.Drawing.Size(256, 32);
            this.buttonPlotOriginal.TabIndex = 21;
            this.buttonPlotOriginal.Text = "Plot original function";
            this.buttonPlotOriginal.UseVisualStyleBackColor = true;
            this.buttonPlotOriginal.Click += new System.EventHandler(this.buttonPlotOriginal_Click);
            // 
            // buttonPlotSpline
            // 
            this.buttonPlotSpline.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlotSpline.Location = new System.Drawing.Point(6, 488);
            this.buttonPlotSpline.Name = "buttonPlotSpline";
            this.buttonPlotSpline.Size = new System.Drawing.Size(256, 32);
            this.buttonPlotSpline.TabIndex = 20;
            this.buttonPlotSpline.Text = "Plot splines";
            this.buttonPlotSpline.UseVisualStyleBackColor = true;
            this.buttonPlotSpline.Click += new System.EventHandler(this.buttonPlotSpline_Click);
            // 
            // interpolationButton
            // 
            this.interpolationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interpolationButton.Location = new System.Drawing.Point(3, 357);
            this.interpolationButton.Name = "interpolationButton";
            this.interpolationButton.Size = new System.Drawing.Size(259, 32);
            this.interpolationButton.TabIndex = 16;
            this.interpolationButton.Text = "Interpolate";
            this.interpolationButton.UseVisualStyleBackColor = true;
            this.interpolationButton.Click += new System.EventHandler(this.interpolationButton_Click);
            // 
            // deleteNodeButton
            // 
            this.deleteNodeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteNodeButton.Location = new System.Drawing.Point(140, 317);
            this.deleteNodeButton.Name = "deleteNodeButton";
            this.deleteNodeButton.Size = new System.Drawing.Size(122, 32);
            this.deleteNodeButton.TabIndex = 18;
            this.deleteNodeButton.Text = "Delete node";
            this.deleteNodeButton.UseVisualStyleBackColor = true;
            this.deleteNodeButton.Click += new System.EventHandler(this.deleteNodeButton_Click);
            // 
            // ppsNumericUpDown
            // 
            this.ppsNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ppsNumericUpDown.Location = new System.Drawing.Point(6, 452);
            this.ppsNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.ppsNumericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.ppsNumericUpDown.Name = "ppsNumericUpDown";
            this.ppsNumericUpDown.Size = new System.Drawing.Size(256, 29);
            this.ppsNumericUpDown.TabIndex = 8;
            this.ppsNumericUpDown.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // addNodeButton
            // 
            this.addNodeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNodeButton.Location = new System.Drawing.Point(6, 317);
            this.addNodeButton.Name = "addNodeButton";
            this.addNodeButton.Size = new System.Drawing.Size(122, 32);
            this.addNodeButton.TabIndex = 17;
            this.addNodeButton.Text = "Add node";
            this.addNodeButton.UseVisualStyleBackColor = true;
            this.addNodeButton.Click += new System.EventHandler(this.addNodeButton_Click);
            // 
            // scaleLabel
            // 
            this.scaleLabel.AutoSize = true;
            this.scaleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scaleLabel.Location = new System.Drawing.Point(6, 632);
            this.scaleLabel.Name = "scaleLabel";
            this.scaleLabel.Size = new System.Drawing.Size(90, 24);
            this.scaleLabel.TabIndex = 7;
            this.scaleLabel.Text = "Plot scale";
            // 
            // interpolationDataGridView
            // 
            this.interpolationDataGridView.AllowUserToAddRows = false;
            this.interpolationDataGridView.AllowUserToDeleteRows = false;
            this.interpolationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.interpolationDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NodeX,
            this.NodeY});
            this.interpolationDataGridView.Location = new System.Drawing.Point(6, 36);
            this.interpolationDataGridView.Name = "interpolationDataGridView";
            this.interpolationDataGridView.RowHeadersVisible = false;
            this.interpolationDataGridView.RowHeadersWidth = 75;
            this.interpolationDataGridView.Size = new System.Drawing.Size(256, 275);
            this.interpolationDataGridView.TabIndex = 0;
            // 
            // NodeX
            // 
            this.NodeX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NodeX.DefaultCellStyle = dataGridViewCellStyle1;
            this.NodeX.HeaderText = "X";
            this.NodeX.Name = "NodeX";
            this.NodeX.Width = 120;
            // 
            // NodeY
            // 
            this.NodeY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NodeY.DefaultCellStyle = dataGridViewCellStyle2;
            this.NodeY.HeaderText = "Y";
            this.NodeY.Name = "NodeY";
            this.NodeY.Width = 120;
            // 
            // interpolationTableLabel
            // 
            this.interpolationTableLabel.AutoSize = true;
            this.interpolationTableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interpolationTableLabel.Location = new System.Drawing.Point(8, 9);
            this.interpolationTableLabel.Name = "interpolationTableLabel";
            this.interpolationTableLabel.Size = new System.Drawing.Size(162, 24);
            this.interpolationTableLabel.TabIndex = 1;
            this.interpolationTableLabel.Text = "Interpolation table:";
            // 
            // ppsLabel
            // 
            this.ppsLabel.AutoSize = true;
            this.ppsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ppsLabel.Location = new System.Drawing.Point(2, 425);
            this.ppsLabel.Name = "ppsLabel";
            this.ppsLabel.Size = new System.Drawing.Size(138, 24);
            this.ppsLabel.TabIndex = 6;
            this.ppsLabel.Text = "Pixels per step:";
            // 
            // scaleButton
            // 
            this.scaleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scaleButton.Location = new System.Drawing.Point(8, 773);
            this.scaleButton.Name = "scaleButton";
            this.scaleButton.Size = new System.Drawing.Size(254, 35);
            this.scaleButton.TabIndex = 3;
            this.scaleButton.Text = "Rescale plot";
            this.scaleButton.UseVisualStyleBackColor = true;
            this.scaleButton.Click += new System.EventHandler(this.scaleButton_Click);
            // 
            // chartDataGridView
            // 
            this.chartDataGridView.AllowUserToAddRows = false;
            this.chartDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.chartDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.chartDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chartDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.chartDataGridView.Location = new System.Drawing.Point(10, 659);
            this.chartDataGridView.Name = "chartDataGridView";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.chartDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.chartDataGridView.RowHeadersWidth = 75;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.chartDataGridView.Size = new System.Drawing.Size(252, 108);
            this.chartDataGridView.TabIndex = 0;
            // 
            // chartMain
            // 
            this.chartMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartMain.Location = new System.Drawing.Point(0, 0);
            this.chartMain.Name = "chartMain";
            this.chartMain.Size = new System.Drawing.Size(1181, 674);
            this.chartMain.TabIndex = 3;
            this.chartMain.Text = "main chart";
            // 
            // fPanel
            // 
            this.fPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.fPanel.Controls.Add(this.label3);
            this.fPanel.Controls.Add(this.fMaxLabel);
            this.fPanel.Controls.Add(this.fMinLabel);
            this.fPanel.Controls.Add(this.fCountTextBox);
            this.fPanel.Controls.Add(this.fMaxTextBox);
            this.fPanel.Controls.Add(this.fMinTextBox);
            this.fPanel.Controls.Add(this.fbutton);
            this.fPanel.Controls.Add(this.fLabel);
            this.fPanel.Controls.Add(this.fTextBox);
            this.fPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.fPanel.Location = new System.Drawing.Point(268, 0);
            this.fPanel.Name = "fPanel";
            this.fPanel.Size = new System.Drawing.Size(1181, 146);
            this.fPanel.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(394, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "count:";
            // 
            // fMaxLabel
            // 
            this.fMaxLabel.AutoSize = true;
            this.fMaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fMaxLabel.Location = new System.Drawing.Point(198, 74);
            this.fMaxLabel.Name = "fMaxLabel";
            this.fMaxLabel.Size = new System.Drawing.Size(51, 24);
            this.fMaxLabel.TabIndex = 7;
            this.fMaxLabel.Text = "max:";
            // 
            // fMinLabel
            // 
            this.fMinLabel.AutoSize = true;
            this.fMinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fMinLabel.Location = new System.Drawing.Point(4, 74);
            this.fMinLabel.Name = "fMinLabel";
            this.fMinLabel.Size = new System.Drawing.Size(46, 24);
            this.fMinLabel.TabIndex = 6;
            this.fMinLabel.Text = "min:";
            // 
            // fCountTextBox
            // 
            this.fCountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fCountTextBox.Location = new System.Drawing.Point(398, 103);
            this.fCountTextBox.Name = "fCountTextBox";
            this.fCountTextBox.Size = new System.Drawing.Size(166, 29);
            this.fCountTextBox.TabIndex = 5;
            this.fCountTextBox.Text = "11";
            // 
            // fMaxTextBox
            // 
            this.fMaxTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fMaxTextBox.Location = new System.Drawing.Point(202, 102);
            this.fMaxTextBox.Name = "fMaxTextBox";
            this.fMaxTextBox.Size = new System.Drawing.Size(166, 29);
            this.fMaxTextBox.TabIndex = 4;
            this.fMaxTextBox.Text = "13";
            // 
            // fMinTextBox
            // 
            this.fMinTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fMinTextBox.Location = new System.Drawing.Point(6, 102);
            this.fMinTextBox.Name = "fMinTextBox";
            this.fMinTextBox.Size = new System.Drawing.Size(166, 29);
            this.fMinTextBox.TabIndex = 3;
            this.fMinTextBox.Text = "2";
            // 
            // fbutton
            // 
            this.fbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fbutton.Location = new System.Drawing.Point(695, 75);
            this.fbutton.Name = "fbutton";
            this.fbutton.Size = new System.Drawing.Size(474, 57);
            this.fbutton.TabIndex = 2;
            this.fbutton.Text = "Generate interpolation nodes";
            this.fbutton.UseVisualStyleBackColor = true;
            this.fbutton.Click += new System.EventHandler(this.fbutton_Click);
            // 
            // fLabel
            // 
            this.fLabel.AutoSize = true;
            this.fLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLabel.Location = new System.Drawing.Point(6, 9);
            this.fLabel.Name = "fLabel";
            this.fLabel.Size = new System.Drawing.Size(472, 24);
            this.fLabel.TabIndex = 1;
            this.fLabel.Text = "Function-interpolation table source  (as C# expression):";
            // 
            // fTextBox
            // 
            this.fTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fTextBox.Location = new System.Drawing.Point(6, 36);
            this.fTextBox.Name = "fTextBox";
            this.fTextBox.Size = new System.Drawing.Size(1163, 29);
            this.fTextBox.TabIndex = 0;
            this.fTextBox.Text = "Math.Pow(3.0 * Math.Pow(x, 6) - 7.0 * x, (1.0/3.0))";
            // 
            // chartPanel
            // 
            this.chartPanel.BackColor = System.Drawing.Color.Red;
            this.chartPanel.Controls.Add(this.chartMain);
            this.chartPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartPanel.Location = new System.Drawing.Point(268, 146);
            this.chartPanel.Name = "chartPanel";
            this.chartPanel.Size = new System.Drawing.Size(1181, 674);
            this.chartPanel.TabIndex = 5;
            // 
            // X
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X.DefaultCellStyle = dataGridViewCellStyle4;
            this.X.HeaderText = "X axis";
            this.X.Name = "X";
            this.X.Width = 75;
            // 
            // Y
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Y.DefaultCellStyle = dataGridViewCellStyle5;
            this.Y.HeaderText = "Y axis";
            this.Y.Name = "Y";
            this.Y.Width = 75;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1449, 820);
            this.Controls.Add(this.chartPanel);
            this.Controls.Add(this.fPanel);
            this.Controls.Add(this.controlPanel);
            this.Name = "MainForm";
            this.Text = "Lab 2 by Bohdan Pylypchenko";
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ppsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interpolationDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMain)).EndInit();
            this.fPanel.ResumeLayout(false);
            this.fPanel.PerformLayout();
            this.chartPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.DataGridView chartDataGridView;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMain;
        private System.Windows.Forms.Button scaleButton;
        private System.Windows.Forms.Label ppsLabel;
        private System.Windows.Forms.Label scaleLabel;
        private System.Windows.Forms.Button interpolationButton;
        private System.Windows.Forms.Label interpolationTableLabel;
        private System.Windows.Forms.DataGridView interpolationDataGridView;
        private System.Windows.Forms.Button deleteNodeButton;
        private System.Windows.Forms.Button addNodeButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn NodeX;
        private System.Windows.Forms.DataGridViewTextBoxColumn NodeY;
        private System.Windows.Forms.NumericUpDown ppsNumericUpDown;
        private System.Windows.Forms.Panel fPanel;
        private System.Windows.Forms.TextBox fTextBox;
        private System.Windows.Forms.Label fLabel;
        private System.Windows.Forms.TextBox fMaxTextBox;
        private System.Windows.Forms.TextBox fMinTextBox;
        private System.Windows.Forms.Button fbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label fMaxLabel;
        private System.Windows.Forms.Label fMinLabel;
        private System.Windows.Forms.TextBox fCountTextBox;
        private System.Windows.Forms.Panel chartPanel;
        private System.Windows.Forms.Button buttonPlotSpline;
        private System.Windows.Forms.Button buttonClearChart;
        private System.Windows.Forms.Button buttonPlotNodes;
        private System.Windows.Forms.Button buttonPlotOriginal;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
    }
}

