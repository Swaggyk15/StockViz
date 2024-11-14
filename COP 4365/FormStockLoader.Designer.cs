namespace COP_4365
{
    partial class FormStockLoader
    {
        // Variable used by the Windows Forms designer for component initialization

        private System.ComponentModel.IContainer components = null;
        // Releases any resources being used by the application
        // Parameter:
        // - disposing: True to release both managed and unmanaged resources; false for unmanaged resources only

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
            this.buttonReloadDisplay = new System.Windows.Forms.Button();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.labelStockTicker = new System.Windows.Forms.Label();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.radioButtonDaily = new System.Windows.Forms.RadioButton();
            this.radioButtonWeekly = new System.Windows.Forms.RadioButton();
            this.radioButtonMonthly = new System.Windows.Forms.RadioButton();
            this.groupBoxPeriod = new System.Windows.Forms.GroupBox();
            this.comboBoxTicker = new System.Windows.Forms.ComboBox();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.groupBoxPeriod.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonReloadDisplay
            // 
            this.buttonReloadDisplay.Location = new System.Drawing.Point(15, 177);
            this.buttonReloadDisplay.Name = "buttonReloadDisplay";
            this.buttonReloadDisplay.Size = new System.Drawing.Size(172, 46);
            this.buttonReloadDisplay.TabIndex = 1;
            this.buttonReloadDisplay.Text = "Reload";
            this.buttonReloadDisplay.UseVisualStyleBackColor = true;
            this.buttonReloadDisplay.Click += new System.EventHandler(this.LoadDisplay);
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Checked = false;
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(86, 17);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(278, 22);
            this.dateTimePickerStartDate.TabIndex = 2;
            this.dateTimePickerStartDate.Value = new System.DateTime(2023, 3, 19, 0, 0, 0, 0);
            this.dateTimePickerStartDate.ValueChanged += new System.EventHandler(this.dateTimePickerStartDate_ValueChanged);
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(86, 51);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(278, 22);
            this.dateTimePickerEndDate.TabIndex = 3;
            this.dateTimePickerEndDate.Value = new System.DateTime(2023, 4, 16, 0, 0, 0, 0);
            this.dateTimePickerEndDate.ValueChanged += new System.EventHandler(this.dateTimePickerEndDate_ValueChanged);
            // 
            // labelStockTicker
            // 
            this.labelStockTicker.AutoSize = true;
            this.labelStockTicker.Location = new System.Drawing.Point(12, 149);
            this.labelStockTicker.Name = "labelStockTicker";
            this.labelStockTicker.Size = new System.Drawing.Size(85, 16);
            this.labelStockTicker.TabIndex = 4;
            this.labelStockTicker.Text = "Stock Ticker:";
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Location = new System.Drawing.Point(12, 20);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(69, 16);
            this.labelStartDate.TabIndex = 5;
            this.labelStartDate.Text = "Start Date:";
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Location = new System.Drawing.Point(9, 54);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(66, 16);
            this.labelEndDate.TabIndex = 6;
            this.labelEndDate.Text = "End Date:";
            // 
            // radioButtonDaily
            // 
            this.radioButtonDaily.AccessibleName = "Day";
            this.radioButtonDaily.AutoSize = true;
            this.radioButtonDaily.Location = new System.Drawing.Point(20, 21);
            this.radioButtonDaily.Name = "radioButtonDaily";
            this.radioButtonDaily.Size = new System.Drawing.Size(59, 20);
            this.radioButtonDaily.TabIndex = 7;
            this.radioButtonDaily.Text = "Daily";
            this.radioButtonDaily.UseVisualStyleBackColor = true;
            this.radioButtonDaily.CheckedChanged += new System.EventHandler(this.aRadioButtonCheckedChanged);
            // 
            // radioButtonWeekly
            // 
            this.radioButtonWeekly.AccessibleName = "Week";
            this.radioButtonWeekly.AutoSize = true;
            this.radioButtonWeekly.Location = new System.Drawing.Point(85, 21);
            this.radioButtonWeekly.Name = "radioButtonWeekly";
            this.radioButtonWeekly.Size = new System.Drawing.Size(74, 20);
            this.radioButtonWeekly.TabIndex = 8;
            this.radioButtonWeekly.Text = "Weekly";
            this.radioButtonWeekly.UseVisualStyleBackColor = true;
            this.radioButtonWeekly.CheckedChanged += new System.EventHandler(this.aRadioButtonCheckedChanged);
            // 
            // radioButtonMonthly
            // 
            this.radioButtonMonthly.AccessibleName = "Month";
            this.radioButtonMonthly.AutoSize = true;
            this.radioButtonMonthly.Location = new System.Drawing.Point(165, 21);
            this.radioButtonMonthly.Name = "radioButtonMonthly";
            this.radioButtonMonthly.Size = new System.Drawing.Size(74, 20);
            this.radioButtonMonthly.TabIndex = 9;
            this.radioButtonMonthly.Text = "Monthly";
            this.radioButtonMonthly.UseVisualStyleBackColor = true;
            this.radioButtonMonthly.CheckedChanged += new System.EventHandler(this.aRadioButtonCheckedChanged);
            // 
            // groupBoxPeriod
            // 
            this.groupBoxPeriod.Controls.Add(this.radioButtonDaily);
            this.groupBoxPeriod.Controls.Add(this.radioButtonWeekly);
            this.groupBoxPeriod.Controls.Add(this.radioButtonMonthly);
            this.groupBoxPeriod.Location = new System.Drawing.Point(12, 83);
            this.groupBoxPeriod.Name = "groupBoxPeriod";
            this.groupBoxPeriod.Size = new System.Drawing.Size(352, 53);
            this.groupBoxPeriod.TabIndex = 12;
            this.groupBoxPeriod.TabStop = false;
            this.groupBoxPeriod.Text = "Period";
            // 
            // comboBoxTicker
            // 
            this.comboBoxTicker.AutoCompleteCustomSource.AddRange(new string[] {
            "AAPL - Day",
            "TSLA - Week"});
            this.comboBoxTicker.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxTicker.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxTicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTicker.FormattingEnabled = true;
            this.comboBoxTicker.Location = new System.Drawing.Point(103, 146);
            this.comboBoxTicker.Name = "comboBoxTicker";
            this.comboBoxTicker.Size = new System.Drawing.Size(261, 24);
            this.comboBoxTicker.TabIndex = 14;
            this.comboBoxTicker.SelectedIndexChanged += new System.EventHandler(this.LoadDisplay);
            // 
            // buttonQuit
            // 
            this.buttonQuit.Location = new System.Drawing.Point(188, 177);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(176, 45);
            this.buttonQuit.TabIndex = 19;
            this.buttonQuit.Text = "Quit";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // FormStockLoader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 231);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.comboBoxTicker);
            this.Controls.Add(this.groupBoxPeriod);
            this.Controls.Add(this.labelEndDate);
            this.Controls.Add(this.labelStartDate);
            this.Controls.Add(this.labelStockTicker);
            this.Controls.Add(this.dateTimePickerEndDate);
            this.Controls.Add(this.dateTimePickerStartDate);
            this.Controls.Add(this.buttonReloadDisplay);
            this.Name = "FormStockLoader";
            this.Text = "Stock Viewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxPeriod.ResumeLayout(false);
            this.groupBoxPeriod.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonReloadDisplay;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.Label labelStockTicker;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.RadioButton radioButtonDaily;
        private System.Windows.Forms.RadioButton radioButtonWeekly;
        private System.Windows.Forms.RadioButton radioButtonMonthly;
        private System.Windows.Forms.GroupBox groupBoxPeriod;
        private System.Windows.Forms.ComboBox comboBoxTicker;
        private System.Windows.Forms.Button buttonQuit;
    }
}

