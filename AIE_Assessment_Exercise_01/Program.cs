/*
 * Appendix 1 - Exercise 1: Adding Two Numbers
 */

using System;

namespace AIE_Assessment_Exercise_01
{
    class Program
    {
        static void Main(string[] args)
        {
            float firstNumber = 0f;
            float secondNumber = 0f;


            if (args.Length < 2) args = new string[] { "11.11", "7.21" };

            firstNumber = float.Parse(args[0]);
            secondNumber = float.Parse(args[1]);

            //float Answer = firstNumber + secondNumber;

            // TODO:
            // Write a function that will sum the two input floating point numbers
            // and return an integer
            // Output your result to the console
            Console.WriteLine(AddNumbers(firstNumber, secondNumber));
        }

        static int AddNumbers(float firstNumber, float secondNumber)
        {

            float answer = firstNumber + secondNumber;
            return (int)answer;         
            
        }
        
        
    }
}
