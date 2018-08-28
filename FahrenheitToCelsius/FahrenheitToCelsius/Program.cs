// Fahrenheit to Celsius Conversion
// Advanced C#
// Written by Stephanie Wilson
// August 28, 2018

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FahrenheitToCelsius
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Fahrenheit temperature >> ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            double celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine(fahrenheit + " degrees Fahrenheit is " + celsius.ToString("F2") + " degrees Celsius");
            Console.ReadLine();
        }
    }
}
