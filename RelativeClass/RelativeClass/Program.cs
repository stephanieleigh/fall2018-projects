// Advanced C#
// Module 05 Assignment
// Classes and Objects
// Stephanie Wilson
// September 22, 2018

// Create examples of creating 2 or more classes within same project:

using System;
using static System.Console;

namespace RelativeClass
{
    class Relative
    {
        public string FirstName { get; set; }
        public string Relationship { get; set; }
        public string BirthMonth { get; set; }
        public int BirthDay { get; set; }
        public int BirthYear { get; set; }

        // constructor
        public Relative(string name, string relation, string bMonth, int bDay, int bYear)
        {
            FirstName = name;
            Relationship = relation;
            BirthYear = bYear;
            BirthMonth = bMonth;
            BirthDay = bDay;
        }

    }

    class CreateRelative
    {
        static void Main(string[] args)
        {
            Relative[] relatives = new Relative[10];
            int x;  // array subscript
            string name;
            string relation;
            string birMonth;
            int birDay;
            int birYear;

            WriteLine("Family Birthdays:");
            
            // loop through array and call method to get values to send to Relative constructor
            for (x = 0; x < relatives.Length; ++x)
            {
                GetRelative(out name, out relation, out birMonth, out birDay, out birYear);
                relatives[x] = new Relative(name, relation, birMonth, birDay, birYear);
            } 

            // display results
            WriteLine("\nYour Relatives:");
            for (x = 0; x < relatives.Length; ++x)
                DisplayRelative(relatives[x]);

            ReadLine();
        }

        // get input from user to create new relative
        static void GetRelative(out string name, out string relation,  out string birMonth, out int birDay, out int birYear)
        {
            string userString;
            Write("\nPlease enter your relative's first name >> ");
            name = ReadLine();
            Write("Please enter how this person is related to you >> ");
            relation = ReadLine();
            Write("Please enter the month this person was born >> ");
            birMonth = ReadLine();
            Write("Please enter the day this person was born >> ");
            userString = ReadLine();
            int.TryParse(userString, out birDay);
            Write("Please enter the year this person was born >> ");
            userString = ReadLine();
            int.TryParse(userString, out birYear);
        }

        // display relatives created
        static void DisplayRelative(Relative newRelative)
        {
            WriteLine("{0, -10} {1, -10} birthday:   {2, -10} {3, 2}, {4}",
                newRelative.FirstName,
                newRelative.Relationship,
                newRelative.BirthMonth,
                newRelative.BirthDay,
                newRelative.BirthYear
                );
        }
    }
}
