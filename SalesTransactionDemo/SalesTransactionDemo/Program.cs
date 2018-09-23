// Advanced C#
// Module 05
// Demonstrates overloaded constructors
// Stephanie Wilson
// September 22, 2018

using System;
using static System.Console;

namespace SalesTransactionDemo
{
    class SalesTransaction
    {
        private const double COMMISSION_RATE = .15;
        private double commission;
        public string SalespersonName { get; set; }
        public double SalesAmount { get; set; }

        // constructors:
        public SalesTransaction(string name, double sales)
        {
            SalespersonName = name;
            SalesAmount = sales;
            commission = this.SalesAmount * COMMISSION_RATE;
            WriteLine("{0} has total sales of {1}. Commission earned is {2}.",
                this.SalespersonName,
                this.SalesAmount.ToString("C2"),
                this.commission.ToString("C2"));
        }

        public SalesTransaction(string name)
        {
            SalespersonName = name;
            SalesAmount = 0;
            commission = 0;
            WriteLine("{0} has not made any sales.", this.SalespersonName);
        }
    } // end of SalesTransaction class

    class CreateTransactions
    {
        static void Main()
        {
            // call constructor that accepts 2 parameters
            SalesTransaction transaction1 = new SalesTransaction("Henderson", 350.00);
            // call constructor that accepts 1 parameter
            SalesTransaction transaction2 = new SalesTransaction("Johnson");

            ReadLine();

        }
    }
}
