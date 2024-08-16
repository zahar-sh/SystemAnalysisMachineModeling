namespace SAMM1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.mainPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.toolsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lahmerPanel = new System.Windows.Forms.GroupBox();
            this.lehmerTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.lehmerCountInput = new System.Windows.Forms.NumericUpDown();
            this.lehmerCountLabel = new System.Windows.Forms.Label();
            this.lehmerALabel = new System.Windows.Forms.Label();
            this.lehmerMLabel = new System.Windows.Forms.Label();
            this.lehmerRLabel = new System.Windows.Forms.Label();
            this.lehmerRInput = new System.Windows.Forms.TextBox();
            this.lehmerAInput = new System.Windows.Forms.TextBox();
            this.lehmerMInput = new System.Windows.Forms.TextBox();
            this.intervalLabel = new System.Windows.Forms.Label();
            this.intervalInput = new System.Windows.Forms.NumericUpDown();
            this.statisticPanel = new System.Windows.Forms.GroupBox();
            this.statisticTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.periodLabel = new System.Windows.Forms.Label();
            this.expectationLabel = new System.Windows.Forms.Label();
            this.dispersionLabel = new System.Windows.Forms.Label();
            this.dispersionValueLabel = new System.Windows.Forms.Label();
            this.periodValueLabel = new System.Windows.Forms.Label();
            this.expectationValueLabel = new System.Windows.Forms.Label();
            this.msdLabel = new System.Windows.Forms.Label();
            this.msdValueLabel = new System.Windows.Forms.Label();
            this.aperiodicLabel = new System.Windows.Forms.Label();
            this.uniformityLabel = new System.Windows.Forms.Label();
            this.aperiodicValueLabel = new System.Windows.Forms.Label();
            this.uniformityValueLabel = new System.Windows.Forms.Label();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.mainPanel.SuspendLayout();
            this.toolsPanel.SuspendLayout();
            this.lahmerPanel.SuspendLayout();
            this.lehmerTablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lehmerCountInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intervalInput)).BeginInit();
            this.statisticPanel.SuspendLayout();
            this.statisticTablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.AutoSize = true;
            this.mainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainPanel.Controls.Add(this.toolsPanel);
            this.mainPanel.Controls.Add(this.chart);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1306, 611);
            this.mainPanel.TabIndex = 10;
            // 
            // toolsPanel
            // 
            this.toolsPanel.AutoSize = true;
            this.toolsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.toolsPanel.Controls.Add(this.lahmerPanel);
            this.toolsPanel.Controls.Add(this.statisticPanel);
            this.mainPanel.SetFlowBreak(this.toolsPanel, true);
            this.toolsPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.toolsPanel.Location = new System.Drawing.Point(3, 3);
            this.toolsPanel.Name = "toolsPanel";
            this.toolsPanel.Size = new System.Drawing.Size(394, 347);
            this.toolsPanel.TabIndex = 9;
            // 
            // lahmerPanel
            // 
            this.lahmerPanel.AutoSize = true;
            this.lahmerPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.lahmerPanel.Controls.Add(this.lehmerTablePanel);
            this.lahmerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lahmerPanel.Location = new System.Drawing.Point(3, 3);
            this.lahmerPanel.Name = "lahmerPanel";
            this.lahmerPanel.Size = new System.Drawing.Size(388, 182);
            this.lahmerPanel.TabIndex = 1;
            this.lahmerPanel.TabStop = false;
            this.lahmerPanel.Text = "Lehmer random params";
            // 
            // lehmerTablePanel
            // 
            this.lehmerTablePanel.AutoSize = true;
            this.lehmerTablePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.lehmerTablePanel.ColumnCount = 2;
            this.lehmerTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.lehmerTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.lehmerTablePanel.Controls.Add(this.lehmerCountInput, 1, 3);
            this.lehmerTablePanel.Controls.Add(this.lehmerCountLabel, 0, 3);
            this.lehmerTablePanel.Controls.Add(this.lehmerALabel, 0, 0);
            this.lehmerTablePanel.Controls.Add(this.lehmerMLabel, 0, 1);
            this.lehmerTablePanel.Controls.Add(this.lehmerRLabel, 0, 2);
            this.lehmerTablePanel.Controls.Add(this.lehmerRInput, 1, 2);
            this.lehmerTablePanel.Controls.Add(this.lehmerAInput, 1, 0);
            this.lehmerTablePanel.Controls.Add(this.lehmerMInput, 1, 1);
            this.lehmerTablePanel.Controls.Add(this.intervalLabel, 0, 4);
            this.lehmerTablePanel.Controls.Add(this.intervalInput, 1, 4);
            this.lehmerTablePanel.Location = new System.Drawing.Point(6, 21);
            this.lehmerTablePanel.Name = "lehmerTablePanel";
            this.lehmerTablePanel.RowCount = 5;
            this.lehmerTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.lehmerTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.lehmerTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.lehmerTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.lehmerTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.lehmerTablePanel.Size = new System.Drawing.Size(376, 140);
            this.lehmerTablePanel.TabIndex = 4;
            // 
            // lehmerCountInput
            // 
            this.lehmerCountInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lehmerCountInput.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.lehmerCountInput.Location = new System.Drawing.Point(172, 87);
            this.lehmerCountInput.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.lehmerCountInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.lehmerCountInput.Name = "lehmerCountInput";
            this.lehmerCountInput.Size = new System.Drawing.Size(201, 22);
            this.lehmerCountInput.TabIndex = 2;
            this.lehmerCountInput.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.lehmerCountInput.ValueChanged += new System.EventHandler(this.RandomChanged);
            // 
            // lehmerCountLabel
            // 
            this.lehmerCountLabel.AutoSize = true;
            this.lehmerCountLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lehmerCountLabel.Location = new System.Drawing.Point(3, 87);
            this.lehmerCountLabel.Margin = new System.Windows.Forms.Padding(3);
            this.lehmerCountLabel.Name = "lehmerCountLabel";
            this.lehmerCountLabel.Size = new System.Drawing.Size(163, 22);
            this.lehmerCountLabel.TabIndex = 0;
            this.lehmerCountLabel.Text = "Count";
            this.lehmerCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lehmerALabel
            // 
            this.lehmerALabel.AutoSize = true;
            this.lehmerALabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lehmerALabel.Location = new System.Drawing.Point(3, 3);
            this.lehmerALabel.Margin = new System.Windows.Forms.Padding(3);
            this.lehmerALabel.Name = "lehmerALabel";
            this.lehmerALabel.Size = new System.Drawing.Size(163, 22);
            this.lehmerALabel.TabIndex = 0;
            this.lehmerALabel.Text = "a";
            this.lehmerALabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lehmerMLabel
            // 
            this.lehmerMLabel.AutoSize = true;
            this.lehmerMLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lehmerMLabel.Location = new System.Drawing.Point(3, 31);
            this.lehmerMLabel.Margin = new System.Windows.Forms.Padding(3);
            this.lehmerMLabel.Name = "lehmerMLabel";
            this.lehmerMLabel.Size = new System.Drawing.Size(163, 22);
            this.lehmerMLabel.TabIndex = 1;
            this.lehmerMLabel.Text = "m";
            this.lehmerMLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lehmerRLabel
            // 
            this.lehmerRLabel.AutoSize = true;
            this.lehmerRLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lehmerRLabel.Location = new System.Drawing.Point(3, 59);
            this.lehmerRLabel.Margin = new System.Windows.Forms.Padding(3);
            this.lehmerRLabel.Name = "lehmerRLabel";
            this.lehmerRLabel.Size = new System.Drawing.Size(163, 22);
            this.lehmerRLabel.TabIndex = 2;
            this.lehmerRLabel.Text = "R";
            this.lehmerRLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lehmerRInput
            // 
            this.lehmerRInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lehmerRInput.Location = new System.Drawing.Point(172, 59);
            this.lehmerRInput.Name = "lehmerRInput";
            this.lehmerRInput.Size = new System.Drawing.Size(201, 22);
            this.lehmerRInput.TabIndex = 5;
            this.lehmerRInput.Text = resources.GetString("lehmerRInput.Text");
            this.lehmerRInput.TextChanged += new System.EventHandler(this.RandomChanged);
            // 
            // lehmerAInput
            // 
            this.lehmerAInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lehmerAInput.Location = new System.Drawing.Point(172, 3);
            this.lehmerAInput.Name = "lehmerAInput";
            this.lehmerAInput.Size = new System.Drawing.Size(201, 22);
            this.lehmerAInput.TabIndex = 6;
            this.lehmerAInput.Text = "48234496";
            this.lehmerAInput.TextChanged += new System.EventHandler(this.RandomChanged);
            // 
            // lehmerMInput
            // 
            this.lehmerMInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lehmerMInput.Location = new System.Drawing.Point(172, 31);
            this.lehmerMInput.Name = "lehmerMInput";
            this.lehmerMInput.Size = new System.Drawing.Size(201, 22);
            this.lehmerMInput.TabIndex = 7;
            this.lehmerMInput.Text = "16777210";
            this.lehmerMInput.TextChanged += new System.EventHandler(this.RandomChanged);
            // 
            // intervalLabel
            // 
            this.intervalLabel.AutoSize = true;
            this.intervalLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.intervalLabel.Location = new System.Drawing.Point(3, 115);
            this.intervalLabel.Margin = new System.Windows.Forms.Padding(3);
            this.intervalLabel.Name = "intervalLabel";
            this.intervalLabel.Size = new System.Drawing.Size(163, 22);
            this.intervalLabel.TabIndex = 8;
            this.intervalLabel.Text = "Interval";
            this.intervalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // intervalInput
            // 
            this.intervalInput.DecimalPlaces = 5;
            this.intervalInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.intervalInput.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.intervalInput.Location = new System.Drawing.Point(172, 115);
            this.intervalInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.intervalInput.Name = "intervalInput";
            this.intervalInput.Size = new System.Drawing.Size(201, 22);
            this.intervalInput.TabIndex = 9;
            this.intervalInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.intervalInput.ValueChanged += new System.EventHandler(this.RandomChanged);
            // 
            // statisticPanel
            // 
            this.statisticPanel.AutoSize = true;
            this.statisticPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.statisticPanel.Controls.Add(this.statisticTablePanel);
            this.statisticPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statisticPanel.Location = new System.Drawing.Point(3, 191);
            this.statisticPanel.Name = "statisticPanel";
            this.statisticPanel.Size = new System.Drawing.Size(388, 153);
            this.statisticPanel.TabIndex = 2;
            this.statisticPanel.TabStop = false;
            this.statisticPanel.Text = "Statistic";
            // 
            // statisticTablePanel
            // 
            this.statisticTablePanel.AutoSize = true;
            this.statisticTablePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.statisticTablePanel.ColumnCount = 2;
            this.statisticTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.statisticTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.statisticTablePanel.Controls.Add(this.periodLabel, 0, 0);
            this.statisticTablePanel.Controls.Add(this.expectationLabel, 0, 3);
            this.statisticTablePanel.Controls.Add(this.dispersionLabel, 0, 4);
            this.statisticTablePanel.Controls.Add(this.dispersionValueLabel, 1, 4);
            this.statisticTablePanel.Controls.Add(this.periodValueLabel, 1, 0);
            this.statisticTablePanel.Controls.Add(this.expectationValueLabel, 1, 3);
            this.statisticTablePanel.Controls.Add(this.msdLabel, 0, 5);
            this.statisticTablePanel.Controls.Add(this.msdValueLabel, 1, 5);
            this.statisticTablePanel.Controls.Add(this.aperiodicLabel, 0, 1);
            this.statisticTablePanel.Controls.Add(this.uniformityLabel, 0, 2);
            this.statisticTablePanel.Controls.Add(this.aperiodicValueLabel, 1, 1);
            this.statisticTablePanel.Controls.Add(this.uniformityValueLabel, 1, 2);
            this.statisticTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statisticTablePanel.Location = new System.Drawing.Point(3, 18);
            this.statisticTablePanel.Name = "statisticTablePanel";
            this.statisticTablePanel.RowCount = 6;
            this.statisticTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.statisticTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.statisticTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.statisticTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.statisticTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.statisticTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.statisticTablePanel.Size = new System.Drawing.Size(382, 132);
            this.statisticTablePanel.TabIndex = 3;
            // 
            // periodLabel
            // 
            this.periodLabel.AutoSize = true;
            this.periodLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.periodLabel.Location = new System.Drawing.Point(3, 3);
            this.periodLabel.Margin = new System.Windows.Forms.Padding(3);
            this.periodLabel.Name = "periodLabel";
            this.periodLabel.Size = new System.Drawing.Size(165, 16);
            this.periodLabel.TabIndex = 1;
            this.periodLabel.Text = "Period";
            this.periodLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // expectationLabel
            // 
            this.expectationLabel.AutoSize = true;
            this.expectationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expectationLabel.Location = new System.Drawing.Point(3, 69);
            this.expectationLabel.Margin = new System.Windows.Forms.Padding(3);
            this.expectationLabel.Name = "expectationLabel";
            this.expectationLabel.Size = new System.Drawing.Size(165, 16);
            this.expectationLabel.TabIndex = 2;
            this.expectationLabel.Text = "Expectation";
            this.expectationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dispersionLabel
            // 
            this.dispersionLabel.AutoSize = true;
            this.dispersionLabel.Location = new System.Drawing.Point(3, 91);
            this.dispersionLabel.Margin = new System.Windows.Forms.Padding(3);
            this.dispersionLabel.Name = "dispersionLabel";
            this.dispersionLabel.Size = new System.Drawing.Size(72, 16);
            this.dispersionLabel.TabIndex = 7;
            this.dispersionLabel.Text = "Dispersion";
            // 
            // dispersionValueLabel
            // 
            this.dispersionValueLabel.AutoSize = true;
            this.dispersionValueLabel.Location = new System.Drawing.Point(174, 91);
            this.dispersionValueLabel.Margin = new System.Windows.Forms.Padding(3);
            this.dispersionValueLabel.Name = "dispersionValueLabel";
            this.dispersionValueLabel.Size = new System.Drawing.Size(14, 16);
            this.dispersionValueLabel.TabIndex = 8;
            this.dispersionValueLabel.Text = "0";
            // 
            // periodValueLabel
            // 
            this.periodValueLabel.AutoSize = true;
            this.periodValueLabel.Location = new System.Drawing.Point(174, 3);
            this.periodValueLabel.Margin = new System.Windows.Forms.Padding(3);
            this.periodValueLabel.Name = "periodValueLabel";
            this.periodValueLabel.Size = new System.Drawing.Size(14, 16);
            this.periodValueLabel.TabIndex = 9;
            this.periodValueLabel.Text = "0";
            // 
            // expectationValueLabel
            // 
            this.expectationValueLabel.AutoSize = true;
            this.expectationValueLabel.Location = new System.Drawing.Point(174, 69);
            this.expectationValueLabel.Margin = new System.Windows.Forms.Padding(3);
            this.expectationValueLabel.Name = "expectationValueLabel";
            this.expectationValueLabel.Size = new System.Drawing.Size(14, 16);
            this.expectationValueLabel.TabIndex = 10;
            this.expectationValueLabel.Text = "0";
            // 
            // msdLabel
            // 
            this.msdLabel.AutoSize = true;
            this.msdLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msdLabel.Location = new System.Drawing.Point(3, 113);
            this.msdLabel.Margin = new System.Windows.Forms.Padding(3);
            this.msdLabel.Name = "msdLabel";
            this.msdLabel.Size = new System.Drawing.Size(165, 16);
            this.msdLabel.TabIndex = 11;
            this.msdLabel.Text = "MeanSquareDeviation";
            this.msdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // msdValueLabel
            // 
            this.msdValueLabel.AutoSize = true;
            this.msdValueLabel.Location = new System.Drawing.Point(174, 113);
            this.msdValueLabel.Margin = new System.Windows.Forms.Padding(3);
            this.msdValueLabel.Name = "msdValueLabel";
            this.msdValueLabel.Size = new System.Drawing.Size(14, 16);
            this.msdValueLabel.TabIndex = 12;
            this.msdValueLabel.Text = "0";
            // 
            // aperiodicLabel
            // 
            this.aperiodicLabel.AutoSize = true;
            this.aperiodicLabel.Location = new System.Drawing.Point(3, 25);
            this.aperiodicLabel.Margin = new System.Windows.Forms.Padding(3);
            this.aperiodicLabel.Name = "aperiodicLabel";
            this.aperiodicLabel.Size = new System.Drawing.Size(65, 16);
            this.aperiodicLabel.TabIndex = 13;
            this.aperiodicLabel.Text = "Aperiodic";
            // 
            // uniformityLabel
            // 
            this.uniformityLabel.AutoSize = true;
            this.uniformityLabel.Location = new System.Drawing.Point(3, 47);
            this.uniformityLabel.Margin = new System.Windows.Forms.Padding(3);
            this.uniformityLabel.Name = "uniformityLabel";
            this.uniformityLabel.Size = new System.Drawing.Size(66, 16);
            this.uniformityLabel.TabIndex = 14;
            this.uniformityLabel.Text = "Uniformity";
            // 
            // aperiodicValueLabel
            // 
            this.aperiodicValueLabel.AutoSize = true;
            this.aperiodicValueLabel.Location = new System.Drawing.Point(174, 25);
            this.aperiodicValueLabel.Margin = new System.Windows.Forms.Padding(3);
            this.aperiodicValueLabel.Name = "aperiodicValueLabel";
            this.aperiodicValueLabel.Size = new System.Drawing.Size(14, 16);
            this.aperiodicValueLabel.TabIndex = 0;
            this.aperiodicValueLabel.Text = "0";
            // 
            // uniformityValueLabel
            // 
            this.uniformityValueLabel.AutoSize = true;
            this.uniformityValueLabel.Location = new System.Drawing.Point(174, 47);
            this.uniformityValueLabel.Margin = new System.Windows.Forms.Padding(3);
            this.uniformityValueLabel.Name = "uniformityValueLabel";
            this.uniformityValueLabel.Size = new System.Drawing.Size(14, 16);
            this.uniformityValueLabel.TabIndex = 15;
            this.uniformityValueLabel.Text = "0";
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(403, 3);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea";
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "RandomSeries";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(900, 600);
            this.chart.TabIndex = 10;
            this.chart.Text = "Histogram";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 611);
            this.Controls.Add(this.mainPanel);
            this.Name = "MainForm";
            this.Text = "System analysis and machine modeling";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.toolsPanel.ResumeLayout(false);
            this.toolsPanel.PerformLayout();
            this.lahmerPanel.ResumeLayout(false);
            this.lahmerPanel.PerformLayout();
            this.lehmerTablePanel.ResumeLayout(false);
            this.lehmerTablePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lehmerCountInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intervalInput)).EndInit();
            this.statisticPanel.ResumeLayout(false);
            this.statisticPanel.PerformLayout();
            this.statisticTablePanel.ResumeLayout(false);
            this.statisticTablePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel mainPanel;

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.FlowLayoutPanel toolsPanel;

        private System.Windows.Forms.GroupBox lahmerPanel;

        private System.Windows.Forms.TableLayoutPanel lehmerTablePanel;
        private System.Windows.Forms.NumericUpDown lehmerCountInput;
        private System.Windows.Forms.Label lehmerCountLabel;
        private System.Windows.Forms.Label lehmerALabel;
        private System.Windows.Forms.Label lehmerMLabel;
        private System.Windows.Forms.Label lehmerRLabel;
        private System.Windows.Forms.TextBox lehmerRInput;
        private System.Windows.Forms.TextBox lehmerAInput;
        private System.Windows.Forms.TextBox lehmerMInput;
        private System.Windows.Forms.GroupBox statisticPanel;
        private System.Windows.Forms.TableLayoutPanel statisticTablePanel;
        private System.Windows.Forms.Label periodLabel;
        private System.Windows.Forms.Label expectationLabel;
        private System.Windows.Forms.Label dispersionLabel;
        private System.Windows.Forms.Label dispersionValueLabel;
        private System.Windows.Forms.Label periodValueLabel;
        private System.Windows.Forms.Label expectationValueLabel;
        private System.Windows.Forms.Label msdLabel;
        private System.Windows.Forms.Label msdValueLabel;
        private System.Windows.Forms.Label aperiodicLabel;
        private System.Windows.Forms.Label uniformityLabel;
        private System.Windows.Forms.Label aperiodicValueLabel;
        private System.Windows.Forms.Label uniformityValueLabel;
        private System.Windows.Forms.Label intervalLabel;
        private System.Windows.Forms.NumericUpDown intervalInput;
    }
}

