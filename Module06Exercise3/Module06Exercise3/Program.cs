// Advanced C#
// Module 06 continued
// Stephanie Wilson
// September 28, 2018

using System;
using static System.Console;

namespace Module06Exercise3
{
    class ForecastTemps
    {
        private static int[] forecastTemp = { 85, 87, 79, 74, 63, 68, 70 };

        public static void DisplayForecast(int day)
        {
            WriteLine("The temperature that day is forecast to be {0}.", forecastTemp[day]);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Here is my example of Arrays:
            WriteLine("High Temperatures for the Week...");
            int[] temperatureList = new int[7];
            int x;
            string inputString;
            for(x = 0; x < temperatureList.Length; ++x)
            {
                Write("Enter the high temperature: ");
                inputString = ReadLine();
                temperatureList[x] = Convert.ToInt32(inputString);
            }

            // Here is my example of calling a method:
            DisplayTemps(temperatureList);
            GetAverage(temperatureList);

            // Here is my example of calling recursive method:
            int num;
            int primeNum;
            WriteLine("\nCheck if a number is prime...");
            Write("Enter a positive number: ");
            num = Convert.ToInt32(ReadLine());
            primeNum = CheckPrime(num, num / 2);

            if(primeNum == 1)
            {
                WriteLine("The number {0} is prime.", num);
            }
            else
            {
                WriteLine("The number {0} is not prime.", num);
            }

            // Here is my example of Try-Catch
            WriteLine("\nDisplay daily forecast...");
            int day;
            try
            {
                Write("\nEnter a day number: ");
                day = Convert.ToInt32(ReadLine());
                ForecastTemps.DisplayForecast(day);
            }
            catch(IndexOutOfRangeException ioore)
            {
                WriteLine(ioore.Message + " No temperature to display");

            }


            ReadLine();
        }
        // Here is my example of Methods

        public static void DisplayTemps(int[] temps)
        {
            WriteLine("Temperatures you entered:");
            for (int x = 0; x < temps.Length; ++x)
                Write("{0, 6}", temps[x]);
        }

        public static void GetAverage(int[] temperatures)
        {
            int totalTemps = 0;
            int averageTemp;
            for(int i = 0; i < temperatures.Length; ++i)
            {
                totalTemps += temperatures[i];
            }
            averageTemp = totalTemps / temperatures.Length;
            WriteLine("\nThe average temperature was {0}.",  averageTemp);
        }

        // Here is my example of Recursion
        public static int CheckPrime(int num1, int num2)
        {
            if(num2 == 1)
            {
                return 1;
            }
            else
            {
                if(num1 % num2 == 0)
                {
                    return 0;
                }
                else
                {
                    return CheckPrime(num1, num2 - 1);
                }
            }
        }
    }
}
