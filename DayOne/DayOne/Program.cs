using System;
using System.Collections.Generic;

namespace DayOne
{
    class Program
    {
        static void Main(string[] args)
        {
            string myNum1 = "";
            Console.WriteLine("Please inter number press return: ");
            myNum1 = Console.ReadLine();
            if (myNum1 == "4 8 15 16 23 42")
                Console.WriteLine("Recalibrating energy core... Complete.");
            else
                Console.WriteLine("FAILURE");
        }
    }
}


