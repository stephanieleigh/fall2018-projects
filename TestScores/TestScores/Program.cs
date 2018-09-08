// Advanced C#
// Test Scores Program
// Stephanie Wilson
// September 7, 2018

using System;
using static System.Console;

namespace TestScores
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MIN_SCORE = 0;
            const int MAX_SCORE = 100;

            string inputString;
            double testScore = 0;
            double numOfScores = 0;
            double totalScore = 0;
            double averageScore = 0;

            Write("Enter a test score between 0-100 or 999 to quit: ");
            inputString = ReadLine();
            testScore = Convert.ToDouble(inputString);

            while (testScore != 999)
            {
                if (testScore < MIN_SCORE || testScore > MAX_SCORE)
                {
                    WriteLine("Invalid test score");
                    break;
                }
                else
                {
                    ++numOfScores;
                    totalScore += testScore;
                    Write("Enter another test score between 0-100 or 999 to quit: ");
                    inputString = ReadLine();
                    testScore = Convert.ToDouble(inputString);
                }
            }

            averageScore = totalScore / numOfScores;
            WriteLine("The total number of valid test scores entered is {0}.", numOfScores);
            WriteLine("The average test score is {0}.", averageScore.ToString("F"));
            ReadLine();
        }
    }
}
