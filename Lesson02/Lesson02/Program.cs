// Advanced C#
// Module 06
// Lesson 02- Rectangle Class
// Stephanie Wilson
// September 28, 2018

using System;
using static System.Console;

namespace Lesson02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Rectangle rect = new Rectangle(10.0, 20.0);
            Rectangle rect = new Rectangle();
            rect.Length = 10.0;
            rect.Width = 20.0;
            double area = rect.GetArea();
            WriteLine("Area of rectangle: {0}", area);

            ReadLine();
        }
    }

    class Rectangle
    {
        private double length;
        private double width;
        /*
        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }
        */
        public double Length
        {
            get
            {
                return length;
            }
            set
            {
                if (value > 0.0)
                    length = value;
            }
        }
        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value > 0.0)
                    width = value;
            }
        }
        public double GetArea()
        {
            return length * width;
        } 
    }
}
