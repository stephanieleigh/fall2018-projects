// Advanced C#
// Count Vowels Program
// Stephanie Wilson
// September 7, 2018

using System;
using static System.Console;

namespace CountVowels
{
    class Program
    {
        static void Main(string[] args)
        {
            string userPhrase;
            int numAs = 0;
            int numEs = 0;
            int numIs = 0;
            int numOs = 0;
            int numUs =0;
            int numCons = 0;
            int i;  // iterator

            WriteLine("VOWEL COUNTING PROGRAM");
            Write("Enter any word or phrase: ");
            userPhrase = ReadLine();

            for(i = 0; i < userPhrase.Length; i++)
            {
                if(userPhrase[i] == 'a' || userPhrase[i] == 'A')
                {
                    numAs++;
                }
                else if(userPhrase[i] == 'e' || userPhrase[i] == 'E')
                {
                    numEs++;
                }
                else if(userPhrase[i] == 'i' || userPhrase[i] == 'I')
                {
                    numIs++;
                }
                else if(userPhrase[i] == 'o' || userPhrase[i] == 'O')
                {
                    numOs++;
                }
                else if(userPhrase[i] == 'u' || userPhrase[i] =='U')
                {
                    numUs++;
                }
                else
                {
                    numCons++;
                }
            }

            WriteLine("The total number of A-s in the phrase is {0}.", numAs);
            WriteLine("The total number of E-s in the phrase is {0}.", numEs);
            WriteLine("The total number of I-s in the phrase is {0}.", numIs);
            WriteLine("The total number of O-s in the phrase is {0}.", numOs);
            WriteLine("The total number of U-s in the phrase is {0}.", numUs);
            WriteLine("The remaining {0} letters are consonants.", numCons);

            ReadLine();

        }
    }
}
