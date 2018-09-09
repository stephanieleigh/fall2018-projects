// Advanced C#
// Guessing Game
// Stephanie Wilson
// September 7, 2018

using System;
using static System.Console;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();  
            int randomNum;
            string inputString;
            int userGuess = 0;
            int numOfGuesses = 0;
            const int MAX_GUESSES = 5;
            int[] guessesList = new int[5];  // array to hold user guesses
            int x;  // subscript

            WriteLine("GUESSING GAME- You get 5 chances to guess the number!");
            WriteLine("-------------------------------------------------------");
            randomNum = rand.Next(1, 101);  // generate random number between 1 and 100

            
            while (numOfGuesses < MAX_GUESSES) 
            {
                for (x = 0; x < guessesList.Length; ++x)
                {
                    Write("Enter a number between 1 and 100: ");
                    inputString = ReadLine();
                    userGuess = Convert.ToInt32(inputString);
                    guessesList[x] = userGuess;  // add user guess to array
                    ++numOfGuesses;  

                    if (userGuess == randomNum)
                    {
                        WriteLine("\nWay to go! You guessed the mystery number!");
                        numOfGuesses = 6;  // set number of guesses to max to break out of loop
                        break;
                    }
                    else if (userGuess < randomNum)
                    {
                        WriteLine("\nSorry, that's too low!");
                    }
                    else
                    {
                        WriteLine("\nOh no! That's too high!");
                    }
                } 
            } 

            WriteLine("\nThe mystery number was {0}.", randomNum);
            WriteLine("Your guesses:");
            // display user guesses
            for (x = 0; x < guessesList.Length; ++x)
                Write("{0, 6}", guessesList[x]);

            ReadLine();
        }
    }
}
