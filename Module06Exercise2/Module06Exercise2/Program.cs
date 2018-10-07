// Advanced C#
// Module 06 continued
// Stephanie Wilson
// September 28, 2018

using System;
using static System.Console;

namespace Module06Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {

            string userInput;
            int hurricaneLevel = 0;
            int windSpeed;

            WriteLine("Hurricane Categories...");
            WriteLine("Enter the wind speed to get the hurricane category: ");
            userInput = ReadLine();
            windSpeed = Convert.ToInt32(userInput);

            if (windSpeed >= 157)
                hurricaneLevel = 5;
            else if (windSpeed >= 130)
                hurricaneLevel = 4;
            else if (windSpeed >= 111)
                hurricaneLevel = 3;
            else if (windSpeed >= 96)
                hurricaneLevel = 2;
            else if (windSpeed >= 74)
                hurricaneLevel = 1;
            else
                WriteLine("That's not a hurricane!");

            // demonstrates use of switch statement
            switch(hurricaneLevel)
            {
                case 5:
                    WriteLine("Wow! That's a category 5 hurricane.");
                    break;
                case 4:
                    WriteLine("That's a category 4 hurricane.");
                    break;
                case 3:
                    WriteLine("That's a category 3 hurricane.");
                    break;
                case 2:
                    WriteLine("That's a category 2 hurricane.");
                    break;
                case 1:
                    WriteLine("That's a category 1 hurricane.");
                    break;
                default:
                    break;
            } // end of switch statement

            // demonstrates exception handling
            WriteLine("\nMiles Per Gallon Program...");
            int milesDriven;
            int gallonsOfGas;
            int mpg;

            try
            {
                Write("Enter miles driven: ");
                milesDriven = Convert.ToInt32(ReadLine());
                Write("Enter gallons of gas purchased: ");
                gallonsOfGas = Convert.ToInt32(ReadLine());
                mpg = milesDriven / gallonsOfGas;
            }
            catch(Exception e)
            {
                mpg = 0;
                WriteLine(e.Message);
            }
            WriteLine("Miles per gallon is {0}", mpg);

            ReadLine();
        }
    }
}
