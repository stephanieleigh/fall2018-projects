// Advanced C#
// Convert Quarters to Dollars
// Stephanie Wilson
// September 15, 2018

using System;
using static System.Console;


namespace ConvertQuartersToDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            int quarterCount;
            string inputString;

            WriteLine("Convert Quarters to Dollars");
            Write("\nEnter a number of quarters to convert: ");
            inputString = ReadLine();
            quarterCount = Convert.ToInt16(inputString);

            // call method
            ConvertQuartersToDollars(quarterCount);

            ReadLine();
        }
        
        private static void ConvertQuartersToDollars(int quarters)
        {
            int dollarCount;
            int quartersRemaining;
            double quartersValue;

            dollarCount = quarters / 4;
            quartersRemaining = quarters % 4;
            quartersValue = quartersRemaining * 25;
            if (dollarCount == 1)
            {
                WriteLine("{0} quarters is {1} dollar and {2} cents.", quarters, dollarCount, quartersValue);
            }
            else
            {
                WriteLine("{0} quarters is {1} dollars and {2} cents.", quarters, dollarCount, quartersValue);
            }
        }

    
    }
}
