using System.Collections.Generic;

namespace COP_4365
{
    internal abstract class Recognizer
    {
        public string patternName { get; set; }
        public int patternSize { get; set; }


        // Constructor for the base class
        // Parameters:
        // - pn: The pattern name
        // - s: The symbol or string associated with the pattern

        public Recognizer(string pn = "?", int s = 1)
        {
            patternName = pn;
            patternSize = s;
        }


        // Determines if the provided subset of candlesticks matches the pattern
        // Parameter:
        // - subset: A list of candlesticks to evaluate
        // Returns:
        // - True if the subset matches the pattern; otherwise, false

        protected abstract bool subsetMatchesPattern(List<Candlestick> subset);


        // Iterates through the candlesticks and checks each subset using subsetMatchesPattern
        // Parameter:
        // - candlesticks: The list of candlestick objects to evaluate
        // Returns:
        // - A list of indices where the pattern matches

        public List<int> Recognize(List<Candlestick> candlesticks)
        {
            List<int> indices = new List<int>(candlesticks.Count / 8);

            int offset = patternSize - 1;
            for(int i = patternSize - 1; i < candlesticks.Count; i++)
            {
                List<Candlestick> subset = candlesticks.GetRange(i - offset, patternSize);
                if (subsetMatchesPattern(subset))
                {
                    indices.Add(i);
                }
            }
            return indices;
        }
    }


    internal class Recognizer_Doji : Recognizer
    {
        // Invokes the constructor of the base class

        public Recognizer_Doji() : base("Doji", 1) { }


        // Implements the subsetMatchesPattern method from the Recognizer base class
        // Checks if the provided subset of candlesticks forms a Doji pattern
        // Parameter:
        // - subset: A list of candlesticks to evaluate
        // Returns:
        // - True if the subset matches the Doji pattern; otherwise, false

        protected override bool subsetMatchesPattern(List<Candlestick> subset)
        {
            if (subset[0].isDoji)
            {
                return true;
            }
            return false;
        }
    }


    internal class Recognizer_LongLeggedDoji : Recognizer
    {
        // Calls the constructor of the parent (base) class

        public Recognizer_LongLeggedDoji() : base("Long-Legged Doji", 1) { }


        // Overrides the subsetMatchesPattern method from the Recognizer base class
        // Checks if the provided subset of candlesticks matches the Long-Legged Doji pattern
        // Parameter:
        // - subset: A list of candlesticks to evaluate
        // Returns:
        // - True if the subset matches the Long-Legged Doji pattern; otherwise, false

        protected override bool subsetMatchesPattern(List<Candlestick> subset)
        {
            if (subset[0].isLongLeggedDoji)
            {
                return true;
            }
            return false;
        }
    }


    internal class Recognizer_DragonflyDoji : Recognizer
    {
        // Invokes the parent class constructor to initialize base properties

        public Recognizer_DragonflyDoji() : base("Dragonfly Doji", 1) { }


        // Overrides the subsetMatchesPattern method from the Recognizer base class
        // Checks if the given subset of candlesticks matches the Dragonfly Doji pattern
        // Parameter:
        // - subset: A list of candlesticks to evaluate
        // Returns:
        // - True if the subset matches the Dragonfly Doji pattern; otherwise, false

        protected override bool subsetMatchesPattern(List<Candlestick> subset)
        {
            if (subset[0].isDragonflyDoji)
            {
                return true;
            }
            return false;
        }
    }


    internal class Recognizer_GravestoneDoji : Recognizer
    {
        // Invokes the constructor of the base class to initialize inherited properties

        public Recognizer_GravestoneDoji() : base("Gravestone Doji", 1) { }


        // Overrides the subsetMatchesPattern method from the Recognizer base class
        // Checks if the provided subset of candlesticks matches the Gravestone Doji pattern
        // Parameter:
        // - subset: A list of candlesticks to evaluate
        // Returns:
        // - True if the subset matches the Gravestone Doji pattern; otherwise, false

        protected override bool subsetMatchesPattern(List<Candlestick> subset)
        {
            if (subset[0].isGravestoneDoji)
            {
                return true;
            }
            return false;
        }
    }


    internal class Recognizer_WhiteMarubozu : Recognizer
    {
        // Invokes the parent class constructor to set up inherited properties

        public Recognizer_WhiteMarubozu() : base("White Marubozu", 1) { }


        // Overrides the subsetMatchesPattern method from the Recognizer base class
        // Checks if the provided subset of candlesticks matches the White Marubozu pattern
        // Parameter:
        // - subset: A list of candlesticks to evaluate
        // Returns:
        // - True if the subset matches the White Marubozu pattern; otherwise, false

        protected override bool subsetMatchesPattern(List<Candlestick> subset)
        {
            if (subset[0].isWhiteMarubozu)
            {
                return true;
            }
            return false;
        }
    }


    internal class Recognizer_BlackMarubozu : Recognizer
    {
        // Calls the base class constructor to initialize inherited properties

        public Recognizer_BlackMarubozu() : base("Black Marubozu", 1) { }


        // Overrides the subsetMatchesPattern method from the Recognizer base class
        // Checks if the provided subset of candlesticks matches the Black Marubozu pattern
        // Parameter:
        // - subset: A list of candlesticks to evaluate
        // Returns:
        // - True if the subset matches the Black Marubozu pattern; otherwise, false

        protected override bool subsetMatchesPattern(List<Candlestick> subset)
        {
            if (subset[0].isBlackMarubozu)
            {
                return true;
            }
            return false;
        }
    }


    internal class Recognizer_BullishHammer : Recognizer
    {
        // Invokes the base class constructor to initialize the object with inherited settings

        public Recognizer_BullishHammer() : base("Bullish Hammer", 1) { }


        // Invokes the base class constructor to initialize the object with inherited settings

        protected override bool subsetMatchesPattern(List<Candlestick> subset)
        {
            if (subset[0].isBullishHammer)
            {
                return true;
            }
            return false;
        }
    }


    internal class Recognizer_BearishHammer : Recognizer
    {
        // Invokes the base class constructor to initialize the object with inherited settings

        public Recognizer_BearishHammer() : base("Bearish Hammer", 1) { }


        // Overrides the subsetMatchesPattern method from the Recognizer base class
        // Checks if the provided subset of candlesticks matches the Bearish Hammer pattern
        // Parameter:
        // - subset: A list of candlesticks to evaluate
        // Returns:
        // - True if the subset matches the Bearish Hammer pattern; otherwise, false

        protected override bool subsetMatchesPattern(List<Candlestick> subset)
        {
            if (subset[0].isBearishHammer)
            {
                return true;
            }
            return false;
        }
    }


    internal class Recognizer_BullishInvertedHammer : Recognizer
    {
        // Calls the base class constructor to initialize inherited fields

        public Recognizer_BullishInvertedHammer() : base("Bullish Inverted Hammer", 1) { }


        // Overrides the subsetMatchesPattern method from the Recognizer base class
        // Checks if the given subset of candlesticks matches the Bullish Inverted Hammer pattern
        // Parameter:
        // - subset: A list of candlesticks to evaluate
        // Returns:
        // - True if the subset matches the Bullish Inverted Hammer pattern; otherwise, false

        protected override bool subsetMatchesPattern(List<Candlestick> subset)
        {
            if (subset[0].isBullishInvertedHammer)
            {
                return true;
            }
            return false;
        }
    }


    internal class Recognizer_BearishInvertedHammer : Recognizer
    {
        // Invokes the constructor of the base class to initialize the object

        public Recognizer_BearishInvertedHammer() : base("Bearish Inverted Hammer", 1) { }


        // Overrides the subsetMatchesPattern method from the Recognizer base class
        // Checks if the given subset of candlesticks matches the Bearish Inverted Hammer pattern
        // Parameter:
        // - subset: A list of candlesticks to evaluate
        // Returns:
        // - True if the subset matches the Bearish Inverted Hammer pattern; otherwise, false

        protected override bool subsetMatchesPattern(List<Candlestick> subset)
        {
            if (subset[0].isBearishInvertedHammer)
            {
                return true;
            }
            return false;
        }
    }


    internal class Recognizer_BullishEngulfing : Recognizer
    {
        // Invokes the constructor of the parent class to initialize inherited properties

        public Recognizer_BullishEngulfing() : base("Bullish Engulfing", 2) { }


        // Overrides the subsetMatchesPattern method from the Recognizer base class
        // Checks if the given subset of candlesticks matches the Bullish Engulfing pattern
        // Parameter:
        // - subset: A list of candlesticks to evaluate
        // Returns:
        // - True if the subset matches the Bullish Engulfing pattern; otherwise, false

        protected override bool subsetMatchesPattern(List<Candlestick> subset)
        {
            double prevOpen = subset[0].Open;
            double prevClose = subset[0].Close;
            if (subset[0].isBearish && subset[1].isBullish && subset[1].Close > prevOpen && subset[1].Open < prevClose)
            {
                return true;
            }
            return false;
        }
    }


    internal class Recognizer_BearishEngulfing : Recognizer
    {
        // Calls the constructor of the base class to initialize inherited fields

        public Recognizer_BearishEngulfing() : base("Bearish Engulfing", 2) { }


        // Overrides the subsetMatchesPattern method from the Recognizer base class
        // Checks if the given subset of candlesticks matches the Bearish Engulfing pattern
        // Parameter:
        // - subset: A list of candlesticks to evaluate
        // Returns:
        // - True if the subset matches the Bearish Engulfing pattern; otherwise, false

        protected override bool subsetMatchesPattern(List<Candlestick> subset)
        {
            double prevOpen = subset[0].Open;
            double prevClose = subset[0].Close;
            if (subset[0].isBullish && subset[1].isBearish && subset[1].Open > prevClose && subset[1].Close < prevOpen)
            {
                return true;
            }
            return false;
        }
    }
}
