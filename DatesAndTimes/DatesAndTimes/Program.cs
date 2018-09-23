using System;
using static System.Console;

namespace DatesAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now;
            //WriteLine(myValue.ToString());
            //WriteLine(myValue.ToShortDateString());
            //WriteLine(myValue.ToShortTimeString());
            //WriteLine(myValue.ToLongDateString());
            //WriteLine(myValue.ToLongTimeString());

            // USING METHODS WITH DATE/TIME:
            //WriteLine(myValue.AddDays(3).ToLongDateString());
            //WriteLine(myValue.AddHours(3).ToLongTimeString());

            // SUBTRACT BY USING NEGATIVE NUMBER:
            //WriteLine(myValue.AddDays(-3).ToLongDateString());

            // GET PARTS OF DATE/TIME:
            //WriteLine(myValue.Month);

            //DateTime myBirthday = new DateTime(1968, 6, 7);
            //WriteLine(myBirthday.ToShortDateString());

            DateTime myBirthday = DateTime.Parse("6/7/1968");
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
            WriteLine(myAge.TotalDays);
            ReadLine();
        }
    }
}
