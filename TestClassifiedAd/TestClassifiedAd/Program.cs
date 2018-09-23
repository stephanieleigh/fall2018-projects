// Advanced C#
// Module 05
// Demonstrates similar example to Hockey Player program
// Stephanie Wilson
// September 22, 2018

using System;
using static System.Console;

namespace TestClassifiedAd
{
    class ClassifiedAd
    {
        private double price;
        public string Category { get; set; }
        public int NumOfWords { get; set; }

        public const double PRICE_PER_WORD = .09;
        public double Price
        {
            get
            {
                price = NumOfWords * PRICE_PER_WORD;
                return price;
            }
        }


        public void DisplayPrice()
        {
            WriteLine("A '{0}' classified ad with {1} words costs {2}.",
                this.Category, this.NumOfWords, this.Price.ToString("C2"));
        }
    }

    class ClassifiedPrice
    {
        static void Main()
        {
            ClassifiedAd ad1 = new ClassifiedAd();
            ad1.Category = "Used Cars";
            ad1.NumOfWords = 45;
            ad1.DisplayPrice();

            ReadLine();
        }
    }
}
