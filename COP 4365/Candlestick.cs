using System;

namespace COP_4365
{
    public class Candlestick
    {
        public DateTime Date { get; set; }
        public Double Open { get; set; }
        public Double High { get; set; }
        public Double Low { get; set; }
        public Double Close { get; set; }
        public long Volume { get; set; }


        // Constructor that sets up a new Candlestick object

        public Candlestick()
        {
            Date = DateTime.Now;
            Open = new Double();
            High = new Double();
            Low = new Double();
            Close = new Double();
            Volume = 0;

            computeProperties();
        }


        // Constructor for creating a Candlestick object with 6 parameters to set its attributes
        // Parameters:
        // - date: The date of the candlestick
        // - open: The opening price
        // - high: The highest price
        // - low: The lowest price
        // - close: The closing price
        // - volume: The trading volume

        public Candlestick(DateTime date, double open, double high, double low, double close, long volume)
        {
            Date = date;
            Open = open;
            High = high;
            Low = low;
            Close = close;
            Volume = volume;

            computeProperties();
        }


        // Copy constructor to create a new Candlestick object from an existing one
        // Parameter:
        // - c: The Candlestick object to copy

        public Candlestick(Candlestick c)
        {
            Date = c.Date;
            Open = c.Open;
            High = c.High;
            Low = c.Low;
            Close = c.Close;
            Volume = c.Volume;

            computeProperties();
        }


        //candlestick properties for Top-level
        public double range { get; private set; }
        public double body { get; private set; }
        public double upperBodyLimit { get; private set; }
        public double lowerBodyLimit { get; private set; }
        public double upperTail { get; private set; }
        public double lowerTail { get; private set; }

        public Boolean isBullish { get; private set; }
        public Boolean isNeutral { get; private set; }
        public Boolean isBearish { get; private set; }

        public Boolean isDoji { get; private set; }
        public Boolean isLongLeggedDoji { get; private set; }
        public Boolean isDragonflyDoji { get; private set; }
        public Boolean isGravestoneDoji { get; private set; }
        public Boolean isMarubozu { get; private set; }
        public Boolean isWhiteMarubozu { get; private set; }
        public Boolean isBlackMarubozu { get; private set; }
        public Boolean isHammer { get; private set; }
        public Boolean isBullishHammer { get; private set; }
        public Boolean isBearishHammer { get; private set; }
        public Boolean isInvertedHammer { get; private set; }
        public Boolean isBullishInvertedHammer { get; private set; }
        public Boolean isBearishInvertedHammer { get; private set; }


        // Checks if the current candlestick matches the Doji pattern
        // Parameter:
        // - bodyTolerance: The tolerance level for the candlestick body size
        // Returns:
        // - True if the candlestick is a Doji, otherwise false

        public Boolean dojiTest(double bodyTolerance = 0.06)
        {
            if (range < double.Epsilon)
            {
                return false; // prevent division by zero
            }
            return body/range <= bodyTolerance;
        }


        // Checks if the current candlestick matches the Long-Legged Doji pattern
        // Parameters:
        // - bodyTolerance: The tolerance level for the candlestick body size
        // - tailDifferenceTolerance: The tolerance for the difference between upper and lower shadows
        // Returns:
        // - True if the candlestick is a Long-Legged Doji, otherwise false

        public Boolean longLeggedDojiTest(double bodyTolerance = 0.05, double tailDifferenceTolerance = 0.13)
        {
            return dojiTest(bodyTolerance) && (Math.Abs(upperTail - lowerTail) <= tailDifferenceTolerance * range);
        }


        // Determines if the current candlestick fits the Dragonfly Doji pattern
        // Parameters:
        // - bodyTolerance: The tolerance level for the candlestick body size
        // - upperTailTolerance: The tolerance for the upper shadow length
        // Returns:
        // - True if the candlestick is a Dragonfly Doji, otherwise false

        public Boolean dragonflyDojiTest(double bodyTolerance = 0.06, double upperTailTolerance = 0.2)
        {
            return dojiTest(bodyTolerance) && (upperTail <= range * upperTailTolerance);
        }


        // Determines if the current candlestick matches the Gravestone Doji pattern
        // Parameters:
        // - bodyTolerance: The tolerance level for the candlestick body size
        // - lowerTailTolerance: The tolerance for the lower shadow length
        // Returns:
        // - True if the candlestick is a Gravestone Doji, otherwise false

        public Boolean gravestoneDojiTest(double bodyTolerance = 0.06, double lowerTailTolerance = 0.2)
        {
            return dojiTest(bodyTolerance) && (lowerTail <= range * lowerTailTolerance);
        }


        // Checks if the current candlestick fits the Marubozu pattern
        // Parameter:
        // - tailTolerance: The tolerance level for the length of shadows (tails)
        // Returns:
        // - True if the candlestick is a Marubozu, otherwise false

        public Boolean marubozuTest(double tailTolerance = 0.025)
        {
            return (upperTail <= range * tailTolerance) && (lowerTail <= range * tailTolerance);
        }


        // Checks if the current candlestick matches the White Marubozu pattern
        // Parameter:
        // - tailTolerance: The tolerance level for the shadow (tail) length
        // Returns:
        // - True if the candlestick is a White Marubozu, otherwise false

        public Boolean whiteMarubozuTest(double tailTolerance = 0.025)
        {
            return marubozuTest(tailTolerance) && isBullish;
        }


        // Checks if the current candlestick fits the Black Marubozu pattern
        // Parameter:
        // - tailTolerance: The tolerance level for the shadow (tail) length
        // Returns:
        // - True if the candlestick is a Black Marubozu, otherwise false

        public Boolean blackMarubozuTest(double tailTolerance = 0.025)
        {
            return marubozuTest(tailTolerance) && isBearish;
        }


        // Determines if the current candlestick matches the Hammer pattern
        // Parameters:
        // - minBodyTolerance: Minimum allowed size for the candlestick body
        // - maxBodyTolerance: Maximum allowed size for the candlestick body
        // - UpperTailTolerance: Tolerance level for the upper shadow length
        // Returns:
        // - True if the candlestick is a Hammer, otherwise false

        public Boolean hammerTest(double minBodyTolerance = 0.2, double maxBodyTolerance = 0.35, double UpperTailTolerance = 0.12)
        {
            return (upperTail <= range * UpperTailTolerance) && (body >= range * minBodyTolerance) && (body <= range * maxBodyTolerance) && (lowerTail >= 2 * body);
        }


        // Checks if the current candlestick matches the Bullish Hammer pattern
        // Parameters:
        // - minBodyTolerance: Minimum allowed size for the candlestick body
        // - maxBodyTolerance: Maximum allowed size for the candlestick body
        // - UpperTailTolerance: Tolerance level for the upper shadow length
        // Returns:
        // - True if the candlestick is a Bullish Hammer, otherwise false

        public Boolean bullishHammerTest(double minBodyTolerance = 0.2, double maxBodyTolerance = 0.35, double UpperTailTolerance = 0.12)
        {
            return hammerTest(minBodyTolerance, maxBodyTolerance, UpperTailTolerance) && isBullish;
        }


        // Checks if the current candlestick matches the Bearish Hammer pattern
        // Parameters:
        // - minBodyTolerance: Minimum allowed size for the candlestick body
        // - maxBodyTolerance: Maximum allowed size for the candlestick body
        // - UpperTailTolerance: Tolerance level for the upper shadow length
        // Returns:
        // - True if the candlestick is a Bearish Hammer, otherwise false

        public Boolean bearishHammerTest(double minBodyTolerance = 0.2, double maxBodyTolerance = 0.35, double UpperTailTolerance = 0.12)
        {
            return hammerTest(minBodyTolerance, maxBodyTolerance, UpperTailTolerance) && isBearish;
        }


        // Checks if the current candlestick matches the Inverted Hammer pattern
        // Parameters:
        // - minBodyTolerance: Minimum allowed size for the candlestick body
        // - maxBodyTolerance: Maximum allowed size for the candlestick body
        // - LowerTailTolerance: Tolerance level for the lower shadow length
        // Returns:
        // - True if the candlestick is an Inverted Hammer, otherwise false

        public Boolean invertedHammerTest(double minBodyTolerance = 0.2, double maxBodyTolerance = 0.35, double LowerTailTolerance = 0.12)
        {
            return (lowerTail <= range * LowerTailTolerance) && (body >= range * minBodyTolerance) && (body <= range * maxBodyTolerance) && (upperTail >= 2 * body);
        }


        // Checks if the current candlestick matches the Bullish Inverted Hammer pattern
        // Parameters:
        // - minBodyTolerance: Minimum allowed size for the candlestick body
        // - maxBodyTolerance: Maximum allowed size for the candlestick body
        // - LowerTailTolerance: Tolerance level for the lower shadow length
        // Returns:
        // - True if the candlestick is a Bullish Inverted Hammer, otherwise false

        public Boolean bullishInvertedHammerTest(double minBodyTolerance = 0.2, double maxBodyTolerance = 0.35, double LowerTailTolerance = 0.12)
        {
            return invertedHammerTest(minBodyTolerance, maxBodyTolerance, LowerTailTolerance) && isBullish;
        }


        // Checks if the current candlestick matches the Bearish Inverted Hammer pattern
        // Parameters:
        // - minBodyTolerance: Minimum allowed size for the candlestick body
        // - maxBodyTolerance: Maximum allowed size for the candlestick body
        // - LowerTailTolerance: Tolerance level for the lower shadow length
        // Returns:
        // - True if the candlestick is a Bearish Inverted Hammer, otherwise false

        public Boolean bearishInvertedHammerTest(double minBodyTolerance = 0.2, double maxBodyTolerance = 0.35, double LowerTailTolerance = 0.12)
        {
            return invertedHammerTest(minBodyTolerance, maxBodyTolerance, LowerTailTolerance) && isBearish;
        }


        // Private helper method to calculate the top-level metrics of a Candlestick object
        // Includes the logic to run the object through all defined pattern tests

        private void computeProperties()
        {
            range = High - Low;
            body = Math.Abs(Open - Close);
            upperBodyLimit = Math.Max(Open, Close);
            lowerBodyLimit = Math.Min(Open, Close);
            upperTail = High - upperBodyLimit;
            lowerTail = lowerBodyLimit - Low;

            computePatterns();
        }


        // Sets the initial values for the top-level properties of a Candlestick object

        private void computePatterns()
        {
            isBullish = Close > Open;
            isNeutral = Close == Open;
            isBearish = Close < Open;

            //Set Pattern Properties
            isDoji = dojiTest();
            isLongLeggedDoji = longLeggedDojiTest();
            isDragonflyDoji = dragonflyDojiTest();
            isGravestoneDoji = gravestoneDojiTest();

            isMarubozu = marubozuTest();
            isWhiteMarubozu = whiteMarubozuTest();
            isBlackMarubozu = blackMarubozuTest();

            isHammer = hammerTest();
            isBullishHammer = bullishHammerTest();
            isBearishHammer = bearishHammerTest();

            isInvertedHammer = invertedHammerTest();
            isBullishInvertedHammer = bullishInvertedHammerTest();
            isBearishInvertedHammer = bearishInvertedHammerTest();
        }
       
    }
}