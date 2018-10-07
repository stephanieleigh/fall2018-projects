// Advanced C#
// Module 07
// Examples of Inheritance

using System;
using static System.Console;

namespace StephanieWilsonModule07Inheritance
{
    // base class
    class Photo
    {
        protected double price;

        public double Width { get; set; }
        public double Height { get; set; }

        public double Price
        {
            get
            {
                if (Width == 8 && Height == 10)
                    price = 3.99;
                else if (Width == 10 && Height == 12)
                    price = 5.99;
                else
                    price = 9.99;

                return price;
            }
        }

        public virtual void DisplayPrice()
        {
            WriteLine("A(n) {0} x {1} photo costs {2}.",
                Width.ToString(), Height.ToString(),
                Price.ToString("C2"));
        }
    }
    // MattedPhoto and FramedPhoto classes demonstrate inheritance
    // derived class: 
    class MattedPhoto : Photo
    {
        public string ColorTint { get; set; }

        public double GetPrice()
        {
            price += 10.0;
            return price;
        }

        public override void DisplayPrice()
        {
            WriteLine("A(n) {0} x {1} photo with a {2} tint added costs {3}.",
                Width.ToString(), Height.ToString(), ColorTint, Price.ToString("C2"));
        }
    }

    // another derived class
    class FramedPhoto : Photo
    {
        public string FrameMaterial { get; set; }
        public string FrameStyle { get; set; }

        public double GetPrice()
        {
            price += 25.0;
            return price;
        }

        public override void DisplayPrice()
        {
            WriteLine("A(n) {0} x {1} photo with a {2} {3} style frame costs {4}.",
                Width.ToString(), Height.ToString(), FrameMaterial,
                FrameStyle, Price.ToString("C2"));
        }
    }

    class PhotoDemo
    {
        static void Main(string[] args)
        {
            // creating an object from the base class
            Photo plainPhoto = new Photo();
            plainPhoto.Width = 8.0;
            plainPhoto.Height = 10.0;
            double photoPrice = plainPhoto.Price;
            plainPhoto.DisplayPrice();

            WriteLine("\n");

            // creating an object from the derived class
            MattedPhoto matPhoto = new MattedPhoto();
            matPhoto.Width = 10.0;
            matPhoto.Height = 12.0;
            matPhoto.ColorTint = "blue";
            photoPrice = matPhoto.Price;
            matPhoto.DisplayPrice();

            WriteLine("\n");

            // creating an object from another derived class
            FramedPhoto framed = new FramedPhoto();
            framed.Width = 5.0;
            framed.Height = 7.5;
            framed.FrameMaterial = "bronze";
            framed.FrameStyle = "Art Deco";
            photoPrice = framed.Price;
            framed.DisplayPrice();

            ReadLine();
        }
    }
}
