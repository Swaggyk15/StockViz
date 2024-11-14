namespace COP_4365
{
    partial class FormChart
    {
        // Variable needed for the Windows Forms designer

        private System.ComponentModel.IContainer components = null;

        // Releases any resources in use
        // Parameter:
        // - disposing: True to release managed resources, false to release only unmanaged resources

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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartStockHistory = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxPattern = new System.Windows.Forms.GroupBox();
            this.comboBoxPatterns = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartStockHistory)).BeginInit();
            this.groupBoxPattern.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartStockHistory
            // 
            chartArea1.Name = "ChartArea1";
            this.chartStockHistory.ChartAreas.Add(chartArea1);
            this.chartStockHistory.Dock = System.Windows.Forms.DockStyle.Top;
            legend1.Name = "Legend1";
            this.chartStockHistory.Legends.Add(legend1);
            this.chartStockHistory.Location = new System.Drawing.Point(0, 0);
            this.chartStockHistory.Name = "chartStockHistory";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
            series1.LabelAngle = -90;
            series1.Legend = "Legend1";
            series1.Name = "Candles";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            series1.YValuesPerPoint = 4;
            this.chartStockHistory.Series.Add(series1);
            this.chartStockHistory.Size = new System.Drawing.Size(1924, 859);
            this.chartStockHistory.TabIndex = 19;
            this.chartStockHistory.Text = "Stock History";
            // 
            // groupBoxPattern
            // 
            this.groupBoxPattern.Controls.Add(this.comboBoxPatterns);
            this.groupBoxPattern.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxPattern.Location = new System.Drawing.Point(0, 1000);
            this.groupBoxPattern.Name = "groupBoxPattern";
            this.groupBoxPattern.Size = new System.Drawing.Size(1924, 55);
            this.groupBoxPattern.TabIndex = 21;
            this.groupBoxPattern.TabStop = false;
            this.groupBoxPattern.Text = "Detect Patterns";
            // 
            // comboBoxPatterns
            // 
            this.comboBoxPatterns.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPatterns.FormattingEnabled = true;
            this.comboBoxPatterns.Location = new System.Drawing.Point(12, 21);
            this.comboBoxPatterns.Name = "comboBoxPatterns";
            this.comboBoxPatterns.Size = new System.Drawing.Size(121, 24);
            this.comboBoxPatterns.TabIndex = 0;
            this.comboBoxPatterns.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // FormChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.groupBoxPattern);
            this.Controls.Add(this.chartStockHistory);
            this.Name = "FormChart";
            this.Text = "FormChart";
            ((System.ComponentModel.ISupportInitialize)(this.chartStockHistory)).EndInit();
            this.groupBoxPattern.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected internal System.Windows.Forms.DataVisualization.Charting.Chart chartStockHistory;
        private System.Windows.Forms.GroupBox groupBoxPattern;
        private System.Windows.Forms.ComboBox comboBoxPatterns;
    }
}