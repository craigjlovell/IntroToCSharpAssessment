/*
 * Appendix1 - Exercise 3: FizzBuzz
 */

using System;

namespace AIE_Assessment_Exercise_03
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1) args = new string[] { "7" };

            int numberOfElements = int.Parse(args[0]);

            // TODO:
            // Write a function to generate output according to the FizzBuzz project brief
            // The function must print the appropriate response for each value i in the 
            // set {1, 2, ... n} in ascending order, each on a separate line

            FizzBuzz(numberOfElements);
        }

        static void FizzBuzz(int numberOfElements)
        {
            
            for(int i = 1; i <= numberOfElements; i++)
            {
                if (i % 3 == 0 && i % 5 == 0) Console.WriteLine("FizzBuzz");
                else if (i % 3 == 0) Console.WriteLine("Fizz");
                else if (i % 5 == 0) Console.WriteLine("Buzz");
                else Console.WriteLine(i);
            }

        }



    }
}
