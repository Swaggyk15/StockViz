using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using COP_4365;

namespace COP_4365
{
    public partial class FormChart : Form
    {
        private String pattern;
        private List<Candlestick> candlesticks;
        private List<int> indices;
        private readonly string dataName;
        private List<Recognizer> recognizers = new List<Recognizer>(15);


        // Constructor for the FormChart class that takes a List<Candlestick> as an argument
        // Parameter:
        // - candlesticks: The list of Candlestick objects to be displayed

        public FormChart(List<Candlestick> candlesticks, String dn)
        {
            dataName = dn;
            InitializeComponent();
            this.candlesticks = candlesticks;
            populateComboBoxPattern();
        }


        // Fills the combobox with pattern names from all the derived recognizer classes

        private void populateComboBoxPattern()
        {
            Recognizer r = null;
            recognizers.Add(r);

            r = new Recognizer_Doji();
            recognizers.Add(r);

            r = new Recognizer_LongLeggedDoji();
            recognizers.Add(r);

            r = new Recognizer_DragonflyDoji();
            recognizers.Add(r);

            r = new Recognizer_GravestoneDoji();
            recognizers.Add(r);

            r = new Recognizer_WhiteMarubozu();
            recognizers.Add(r);

            r = new Recognizer_BlackMarubozu();
            recognizers.Add(r);

            r = new Recognizer_BullishHammer();
            recognizers.Add(r);

            r = new Recognizer_BearishHammer();
            recognizers.Add(r);

            r = new Recognizer_BullishInvertedHammer();
            recognizers.Add(r);

            r = new Recognizer_BearishInvertedHammer();
            recognizers.Add(r);

            r = new Recognizer_BullishEngulfing();
            recognizers.Add(r);

            r = new Recognizer_BearishEngulfing();
            recognizers.Add(r);

            comboBoxPatterns.Items.Add("None");
            for (int i = 1; i < recognizers.Count; i++)
            {
                comboBoxPatterns.Items.Add(recognizers[i].patternName);
            }
            comboBoxPatterns.SelectedIndex = 0;
        }


        // Removes previous legend and annotation items, then updates the chart based on the pattern selected by the user
        // Parameters:
        // - sender: The source of the event
        // - e: Event arguments associated with the action

        private void LoadPatternDetection(object sender, EventArgs e)
        {
            //FormChartUpdateText();
            chartStockHistory.Annotations.Clear();
            chartStockHistory.Legends[0].CustomItems.Clear();
            if (comboBoxPatterns.SelectedIndex == 0) { }
            else
            {
                int i = comboBoxPatterns.SelectedIndex;

                chartStockHistory.Legends[0].CustomItems.Add(Color.LightPink, recognizers[i].patternName);
                indices = recognizers[i].Recognize(candlesticks);
                AnnotateChart(chartStockHistory, indices, Color.LightPink);
            }
        }


        // Adds rectangle annotations to the specified chart for the candlestick indexes provided
        // Parameters:
        // - chart: The chart control object to annotate
        // - indices: A list of candlestick indexes to highlight
        // - subpattern: The specific subpattern associated with the annotations

        private void AnnotateChart(Chart chart, List<int> indices, Color color)
        {
            string txt = "|\n|\n|";

            foreach (int index in indices)
            {
                RectangleAnnotation rect = new RectangleAnnotation();
                rect.Text = txt;
                rect.ForeColor = color;
                rect.LineColor = color;
                rect.BackColor = Color.FromArgb(75, color);
                rect.Font = new Font("Arial", 7, FontStyle.Italic);
                rect.AxisX = chart.ChartAreas["ChartArea1"].AxisX;
                rect.AxisY = chart.ChartAreas["ChartArea1"].AxisY;
                rect.AnchorDataPoint = chart.Series[0].Points[index];
                rect.AnchorOffsetY = 2.5;
                chart.Annotations.Add(rect);
            }
        }


        // Updates the text displayed on the form
        // Parameters:
        // - sender: The source of the event
        // - e: Event arguments related to the action

        public void FormChartUpdateText()
        {
            if (pattern == "None")
            {
                Text = dataName.Substring(0, dataName.IndexOf('-'));
            }
            else
            {
                Text = dataName.Substring(0, dataName.IndexOf('-')) + " | Pattern: " + pattern;
            }
        }


        // Sets the pattern property using the text from the ComboBox that triggered the event,
        // then calls the LoadPatternDetection() method
        // Parameters:
        // - sender: The source of the event (ComboBox control)
        // - e: Event arguments associated with the action

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pattern = ((ComboBox)sender).Text;
            FormChartUpdateText();
            LoadPatternDetection(sender, e);
        }
    }
}