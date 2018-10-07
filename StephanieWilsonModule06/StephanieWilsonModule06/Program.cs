//Advanced C#
// Module 06- Example of Inheritance
// Stephanie Wilson
// September 28, 2018

using System;
using static System.Console;

namespace StephanieWilsonModule06
{
    class PackageDemo
    {
        static void Main(string[] args)
        {
            InsuredPackage pkg1 = new InsuredPackage();
            double deliveryCharge;
            double totalDeliveryCharge;
            pkg1.IdNumber = 3456;
            pkg1.RecipientName = "Butler";
            pkg1.PkgWeight = 62;
            deliveryCharge = pkg1.GetPrice();
            pkg1.PackageValue = deliveryCharge;
            totalDeliveryCharge = pkg1.GetFinalPrice();

            WriteLine("Package number {0} for {1} weighs {2} ounces.", pkg1.IdNumber, pkg1.RecipientName, pkg1.PkgWeight);
            WriteLine("The delivery charge is {0}.", deliveryCharge.ToString("C2"));
            WriteLine("With insurance, the delivery charge is {0}.", totalDeliveryCharge.ToString("C2"));
           
            ReadLine();

        }
    }

    // base class
    class Package
    {
        private double deliveryPrice;

        public int IdNumber { get; set; }
        public string RecipientName { get; set; }
        public double PkgWeight { get; set; }
        
        // method to calculate delivery charge based on weight of pkg
        public double GetPrice()
        {
            if (PkgWeight <= 32)
                deliveryPrice = 5.00;
            else
                deliveryPrice = 5.00 + ((45 - 32) * .12);

            return deliveryPrice;
        }
    }

    // derived class
    class InsuredPackage : Package
    {
        public double PackageValue { get; set; }

        // method to get total delivery charge including insurance
        public double GetFinalPrice()
        {
            if (PackageValue <= 20.00)
                PackageValue += 1.00;
            else
                PackageValue += 2.50;

            return PackageValue;
        }
    }
}
