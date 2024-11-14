using System;
using System.Collections.Generic;
using System.IO;

namespace COP_4365
{
    internal class StockDataReader
    {
        // Initializes a new instance of the StockDataReader class

        public StockDataReader() { }


        // Takes the file directory path and the start and end dates to define the requested data range
        // Reads and parses the stock data CSV at the provided path
        // Returns an empty list if the file is not found or if the CSV header is incorrectly formatted
        // Parameter:
        // - path: The file path to the stock data CSV
        // - startDate: The start date for the data range
        // - endDate: The end date for the data range
        // Returns:
        // - A list of Candlestick objects, with each object representing a line from the CSV

        public List<Candlestick> ReadStockData(string path, DateTime startDate, DateTime endDate)
        {
            List<Candlestick> selectedLines = new List<Candlestick>();
            if (File.Exists(path))
            {
                String[] allLines = System.IO.File.ReadAllLines(path);
                String header = allLines[0];
                if (header == "Date,Open,High,Low,Close,Adj Close,Volume")
                {
                    for (int i = 1; i < allLines.Length; i++)
                    {
                        String[] line = allLines[i].Split(',');
                        DateTime date = createDateTime(line);
                        if (DateTime.Compare(date, endDate.Date) <= 0 && DateTime.Compare(date, startDate.Date) >= 0)
                        {
                            double open = Math.Round(double.Parse(line[1]), 2);
                            double high = Math.Round(double.Parse(line[2]), 2);
                            double low = Math.Round(double.Parse(line[3]), 2);
                            double close = Math.Round(double.Parse(line[4]), 2);
                            long volume = long.Parse(line[6]);
                            selectedLines.Add(new Candlestick(date.Date, open, high, low, close, volume));
                        }
                    }
                    return selectedLines;
                }
                return selectedLines;
            }
            return selectedLines;
        }


        // Private helper method used by ReadStockData to create a new DateTime object from a line in the CSV file
        // Parameter:
        // - line: The current line of data from the CSV
        // Returns:
        // - A DateTime object constructed from the date information in the line

        private DateTime createDateTime(String[] line)
        {
            String[] date = line[0].Split('-');
            DateTime candleDate = new DateTime(int.Parse(date[0].TrimStart(new Char[] {'0'})), int.Parse(date[1].TrimStart(new Char[] {'0'})), int.Parse(date[2].TrimStart(new Char[] {'0'})));
            return candleDate;
        }
    }
}