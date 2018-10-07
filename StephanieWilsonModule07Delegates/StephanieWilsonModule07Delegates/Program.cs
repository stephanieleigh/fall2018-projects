// Advanced C#
// Module 07
// Example of using Delegates
// Stephanie Wilson
// October 7, 2018

using System;
using static System.Console;


namespace StephanieWilsonModule07Delegates
{
    // create a delegate:
    delegate double TotalPayDelegate(double totalHrs);
    class Program
    {
        public static double GetBasicPay(double totalHrs)
        {
            const double BASE_RATE = 12.00;
            double totalPay = totalHrs * BASE_RATE;
            return totalPay;

        }

        public static double GetOvertimePay(double totalHrs)
        {
            const double BASE_RATE = 12.00;
            double overtime = (totalHrs - 40) * (BASE_RATE / 2);
            double totalPay = (totalHrs * BASE_RATE) + overtime;
            return totalPay;

        }
        static void Main(string[] args)
        {
            double totalHrs;
            double totalPay;
            // declare delegate objects
            TotalPayDelegate payDel1, payDel2;
            // assign a different method to each delegate
            payDel1 = new TotalPayDelegate(GetBasicPay);
            payDel2 = new TotalPayDelegate(GetOvertimePay);

            Write("Enter number of hours worked: ");
            totalHrs = Convert.ToDouble(ReadLine());
            // based on number of hrs worked, call appropriate delegate to call method
            // that calculates total pay
            if (totalHrs <= 40)
                totalPay = payDel1(totalHrs);
            else
                totalPay = payDel2(totalHrs);

            WriteLine("Total pay is {0}", totalPay.ToString("C2"));

            ReadLine();
        }
    }
}
