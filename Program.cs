/*
 * Average Method
 * Pawelski
 * 2/1/2022
 * Read over the code and run the program a few times to determine
 * what the program does and how it works. Once you understand the
 * program, answer the questions on the activity sheet.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates an array to hold the appropriate amount of numbers
            int length;
            Console.Write("How many numbers would you like to enter >> ");
            length = Convert.ToInt32(Console.ReadLine());
            int[] userNumbers = new int[length];

            // Populates the array
            for(int i = 0; i < userNumbers.Length; i++)
            {
                Console.Write("Enter a number >> ");
                userNumbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The average of the numbers is " + CalculateAverage(userNumbers));
        }

        /*
         * The CalculateAverage method calculates the average of a passed array.
         * numbers represents a list of numbers to find the average of
         * returns the average of the numbers
         */
        private static double CalculateAverage(int[] numbers)
        {
            double total = 0, average;
            foreach(int number in numbers)
            {
                total += number;
            }
            average = total / numbers.Length;
            return average;
        }
    }
}
