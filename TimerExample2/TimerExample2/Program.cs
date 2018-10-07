// Advanced C#
// Module 07
// Timer Example from MVA tutorial
// Stephanie Wilson
// October 5, 2018

using System;
using static System.Console;
using System.Timers;

namespace TimerExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer myTimer = new Timer(2000);

            myTimer.Elapsed += MyTimer_Elapsed;
            myTimer.Elapsed += MyTimer_Elapsed1;

            myTimer.Start();

            WriteLine("Press enter to remove the red event.");

            ReadLine();

            myTimer.Elapsed -= MyTimer_Elapsed1;

            ReadLine();
        }

        private static void MyTimer_Elapsed1(object sender, ElapsedEventArgs e)
        {
            ForegroundColor = ConsoleColor.Red;
            WriteLine("Elapsed1: {0:HH:mm:ss.fff}", e.SignalTime);
        }

        private static void MyTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            ForegroundColor = ConsoleColor.White;
            WriteLine("Elapsed: {0:HH:mm:ss.fff}", e.SignalTime);
        }
    }
}
