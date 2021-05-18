/*
 * Appendix 2 - Exercise 2: Sorting an Array (Descending)
 */


using System;

namespace AIE_Assessment_Exercise_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input comma separated list of numbers");
            string lineOfText = Console.ReadLine();
            string[] values = lineOfText.Split(',');

            int[] numbers = new int[values.Length];
            for (int i = 0; i < values.Length; i++)
            {
                numbers[i] = Int32.Parse(values[i]);
            }
            
            // TODO:
            // Write a function that accepts the integer array 'numbers' and outputs the sorted array to the console
            SortDescending(numbers);

            PrintArray(numbers);

        }

        static void PrintArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i]);
                Console.Write(",");
            }
        }

        static void SortDescending(int[] numbers)
        {
            bool isSorted = false;
            while (!isSorted)
            {
                isSorted = true;
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        Swap(numbers, i, i + 1);
                        isSorted = false;
                    }
                }
            }
        }

        public static void Swap(int[] numbers, int i, int j)
        {
            int tmp = numbers[i];
            numbers[i] = numbers[j];
            numbers[j] = tmp;
        }
        
    }
}
