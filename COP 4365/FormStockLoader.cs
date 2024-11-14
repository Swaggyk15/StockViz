using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace COP_4365
{
    public partial class FormStockLoader : Form
    {
        private DateTime startDate;
        private DateTime endDate;
        private string period;
        private string path;
        private const String folder = "Stock Data";
        private FormChart candleChart;
        private double maxY;
        private double minY;
        private double padding;


        // Initializes a new instance of the FormStockLoader class

        public FormStockLoader()
        {
            InitializeComponent();
        }


        // Sets the form's text to "Stock Loader" when the form is loaded
        // Parameters:
        // - sender: The source of the event
        // - e: Event arguments associated with the form load event

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "Stock Loader";
        }


        // Creates a new FormChart instance using the current input control values 
        // and initializes the StockDataReader class
        // Parameters:
        // - sender: The source of the event
        // - e: Event arguments related to the action

        private void LoadDisplay(object sender, EventArgs e)
        {
            //Update attributes
            startDate = dateTimePickerStartDate.Value.Date;
            endDate = dateTimePickerEndDate.Value.Date;
            path = folder + @"\" + comboBoxTicker.Text + ".csv";

            //Read stock data
            StockDataReader reader = new StockDataReader();
            List<Candlestick> candlesticks = reader.ReadStockData(path, startDate, endDate);

            //If data was found, display in a new candleChart, else display the "Error" dialog
            if (candlesticks.Count == 0)
            {
                FormError error = new FormError();
                error.ShowDialog();
            }
            else
            {
                //Instantiate a new FormChart
                candleChart = new FormChart(candlesticks, comboBoxTicker.Text);

                //Create a data table for the candleChart DataSource
                DataTable stockHistory = CreateDataTable(candlesticks);

                double maxY = candlesticks.Max(cs => cs.High);
                double minY = candlesticks.Min(cs => cs.Low);
                double padding = 0.10 * (maxY - minY);
                ConfigureChart(stockHistory, maxY, minY, padding);

                candleChart.Show();
            }
        }


        // Generates a stock data table with columns (Date, Open, High, Low, Close, Volume) 
        // from a provided list of Candlestick objects
        // Parameter:
        // - candles: The list of Candlestick objects to populate the table

        private DataTable CreateDataTable(List<Candlestick> candles)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Date");
            dt.Columns.Add("Open");
            dt.Columns.Add("High");
            dt.Columns.Add("Low");
            dt.Columns.Add("Close");
            dt.Columns.Add("Volume");

            foreach (Candlestick c in candles)
            {
                String[] line = new string[6];
                line[0] = c.Date.ToString();
                line[1] = c.Open.ToString();
                line[2] = c.High.ToString();
                line[3] = c.Low.ToString();
                line[4] = c.Close.ToString();
                line[5] = c.Volume.ToString();

                dt.Rows.Add(line);
            }

            return dt;
        }


        // Closes the form and ends the program when the user clicks the button
        // Parameters:
        // - sender: The source of the event (usually a button)
        // - e: Event arguments associated with the click action

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // Handles the event for all radio buttons, updating the period attribute as needed
        // Parameters:
        // - sender: The source of the event (radio button)
        // - e: Event arguments related to the change

        private void aRadioButtonCheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked == true)
            {
                period = rb.AccessibleName;
                string[] fullFileNames = Directory.GetFiles("Stock Data", "*-" + period + ".csv");

                comboBoxTicker.Items.Clear();
                foreach (string fullName in fullFileNames)
                {
                    comboBoxTicker.Items.Add(Path.GetFileNameWithoutExtension(fullName));
                }
            }
        }


        // Updates the startDate attribute when the value of dateTimePickerStartDate changes
        // Parameters:
        // - sender: The source of the event (dateTimePicker control)
        // - e: Event arguments related to the date change

        private void dateTimePickerStartDate_ValueChanged(object sender, EventArgs e)
        {
            startDate = dateTimePickerStartDate.Value.Date;
        }


        // Updates the endDate attribute when the value of dateTimePickerEndDate changes
        // Parameters:
        // - sender: The source of the event (dateTimePicker control)
        // - e: Event arguments related to the date change

        private void dateTimePickerEndDate_ValueChanged(object sender, EventArgs e)
        {
               endDate = dateTimePickerEndDate.Value.Date;
        }


        // Configures the chart control within the FormChart instance and binds it to the provided DataTable
        // Parameter:
        // - dt: The DataTable containing stock data to display in the chart

        private void ConfigureChart(DataTable dt, double maxY, double minY, double padding)
        {
            candleChart.chartStockHistory.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineWidth = 0;
            candleChart.chartStockHistory.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineWidth = 0;
            candleChart.chartStockHistory.ChartAreas["ChartArea1"].AxisX.Title = "Date";
            candleChart.chartStockHistory.ChartAreas["ChartArea1"].AxisY.Title = "Price ($)";
            candleChart.chartStockHistory.ChartAreas["ChartArea1"].AxisY.Maximum = maxY + padding;
            candleChart.chartStockHistory.ChartAreas["ChartArea1"].AxisY.Minimum = Math.Max(minY - padding, 0); //Doesn't allow a negative y minimum
            candleChart.chartStockHistory.Series["Candles"].XValueMember = "Date";
            candleChart.chartStockHistory.Series["Candles"].YValueMembers = "High,Low,Open,Close";
            candleChart.chartStockHistory.Series["Candles"].XValueType = ChartValueType.Date;
            candleChart.chartStockHistory.Series["Candles"].CustomProperties = "PriceDownColor=Red,PriceUpColor=Green";
            candleChart.chartStockHistory.Series["Candles"]["ShowOpenClose"] = "Both";
            candleChart.chartStockHistory.DataManipulator.IsStartFromFirst = true;
            candleChart.chartStockHistory.DataSource = dt;
            candleChart.chartStockHistory.DataBind();
            candleChart.chartStockHistory.Series[0].Name = comboBoxTicker.Text;
            candleChart.chartStockHistory.ChartAreas["ChartArea1"].AxisX.Interval = 0;
            candleChart.chartStockHistory.ChartAreas["ChartArea1"].AxisX.IntervalType = DateTimeIntervalType.Days;
            candleChart.chartStockHistory.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "dd/MM/yyyy";
        }
    }
}