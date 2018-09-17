// Advanced C#
// Painting Estimate Program
// Stephanie Wilson
// September 15, 2018

using System;
using static System.Console;

namespace PaintingEstimate
{
    class Program
    {
        static void Main(string[] args)
        {
            double wallLength;
            double wallHeight;
            string inputString;
            double squareFeet;
            double paintCost;
            double laborCost;

            Write("Enter length of wall in feet: ");
            inputString = ReadLine();
            wallLength = Convert.ToDouble(inputString);
            Write("Enter height of wall in feet: ");
            inputString = ReadLine();
            wallHeight = Convert.ToDouble(inputString);

            squareFeet = GetSquareFeet(wallLength, wallHeight);
            paintCost = GetPaintCost(squareFeet);
            laborCost = GetLaborCost(squareFeet);
            DisplayEstimate(squareFeet, paintCost, laborCost);

            ReadLine();
        }

        // method to get total sq. feet of room
        private static double GetSquareFeet(double wallLength, double wallHeight)
        {
            double wallSquareFeet;
            double totalSquareFeet;
            const double DOOR_SQ_FEET = 24;
            double finalSquareFeet;

            wallSquareFeet = wallLength * wallHeight;
            totalSquareFeet = wallSquareFeet * 4;
            finalSquareFeet = totalSquareFeet - DOOR_SQ_FEET;
            return finalSquareFeet;
        }


        // method to get total cost of paint for room
        private static double GetPaintCost(double squareFeet)
        {
            const double COST_PAINT = 1.50;
            double totalPaintCost;

            totalPaintCost = squareFeet * COST_PAINT;
            return totalPaintCost;
        }

        // method to get total labor cost of painting room
        private static double GetLaborCost(double squareFeet)
        {
            const double RATE_PER_SQ_FOOT = 6.00;
            double totalLabor;

            totalLabor = squareFeet * RATE_PER_SQ_FOOT;
            return totalLabor;
        }

        // method to display final estimate
        private static void DisplayEstimate(double squareFeet, double paintCost, double laborCost)
        {
            double totalEstimate;

            totalEstimate = squareFeet + paintCost + laborCost;
            WriteLine("\nPAINTING ESTIMATE---");
            WriteLine("\nTotal square feet to paint: {0}", squareFeet.ToString("F2"));
            WriteLine("Total cost of paint: {0}", paintCost.ToString("C"));
            WriteLine("Total cost of labor: {0}", laborCost.ToString("C"));
            WriteLine("Total estimate: {0}", totalEstimate.ToString("C"));
        }


    }
}
