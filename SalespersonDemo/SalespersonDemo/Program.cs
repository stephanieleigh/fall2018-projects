// Advanced C#
// Module 08- Inheritance, Objects, and Properties
// Stephanie Wilson
// October 11, 2018

using System;
using static System.Console;

namespace SalespersonDemo
{
    // interface that holds methods implemented by child classes
    interface ISellable
    {
        void SalesSpeech();
        void MakeSale(int itemSold);
    }

    abstract class Salesperson
    {
        private string firstName;
        private string lastName;

        // constructor
        public Salesperson(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        // properties
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // method to return full name
        public string GetFullName()
        {
            return (this.firstName + " " + this.lastName);
        }

        public virtual void DisplayName()
        {
            WriteLine("The new salesperson is {0}.", this.GetFullName());
        }
    }
    // child classes that inherit from Salesperson abstract class and ISellable interface
    class RealEstateSalesperson : Salesperson, ISellable
    {
        private double totalSales = 0;
        private double totalCommission = 0;
        private double commissionRate = 0;
        // constructor that requires an additional field holding salesperson's commission rate
        public RealEstateSalesperson(string firstName, string lastName, double commissionRate) : base(firstName, lastName)
        {
            this.commissionRate = commissionRate;
        }

        public double TotalSales { get; set; }
        public double TotalCommission { get; set; }
        public double CommissionRate { get; set; }
    
        // overrides virtual method of abstract Salesperson class
        public override void DisplayName()
        {
            WriteLine("The new real estate agent is {0}. His/Her commission rate is {1}.\n", this.GetFullName(), this.commissionRate.ToString("P1"));
        }
        // implements methods of ISellable interface
        public void SalesSpeech()
        {
            WriteLine("Congratulations on your decision to buy a new home! What areas are you looking to buy in?\n");
        }

        public void MakeSale(int houseValue)
        {
            double commission = houseValue * this.commissionRate;
            totalSales += houseValue;
            totalCommission += commission;
            WriteLine("{0} earned {1} commission on this sale. His total sales are now {2} and his total commission is {3}.",
                this.GetFullName(), commission.ToString("C2"), this.totalSales.ToString("C2"), this.totalCommission.ToString("C2"));
        }
    }

    class GirlScout : Salesperson, ISellable
    {
        //private int boxesSold = 0;
        public GirlScout(string firstName, string lastName) : base(firstName, lastName) { }

        public int BoxesSold { get; set; }

        // overrides virtual method of abstract Salesperson class
        public override void DisplayName()
        {
            WriteLine("The name of your local Girl Scout is {0}.\n", this.GetFullName());
        }
        // implements methods of ISellable interface
        public void MakeSale(int numBoxes)
        {
            this.BoxesSold += numBoxes;
            WriteLine("{0} sold a total of {1} boxes of cookies.\n", this.GetFullName(), this.BoxesSold);
        }

        public void SalesSpeech()
        {
            WriteLine("Thank you for helping me to meet my goal. What's your favorite Girl Scout cookie?\n");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // create new realestatesalesperson object
            RealEstateSalesperson res1 = new RealEstateSalesperson("Daniel", "Jackson", .075);
            res1.DisplayName();
            res1.SalesSpeech();
            res1.MakeSale(69900);
            res1.MakeSale(125000);
            res1.MakeSale(17999);

            WriteLine("\n");
            // create new girlscout object
            GirlScout gs1 = new GirlScout("Jessica", "Morgan");
            gs1.DisplayName();
            gs1.SalesSpeech();
            gs1.MakeSale(5);
            gs1.MakeSale(3);
            gs1.MakeSale(12);

            ReadLine();

        }
    }
}
