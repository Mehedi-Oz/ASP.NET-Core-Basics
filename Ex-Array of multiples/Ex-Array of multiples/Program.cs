using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Array_of_multiples
{
    internal class Program
    {

        /*
         * Define and initialise two integers (num, length)
         * (7, 5) - > [7, 14, 21, 28, 35]
         * Create int array with size length
         * loop through and insert the (loop counter x num) into the array
         * print the final array
         */
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a leangth: ");
            int length = Convert.ToInt32(Console.ReadLine());

            int[] timesArray = new int[length];

            for (var i = 0; i < length; i++)
            {
                timesArray[i] = num * (i + 1);
            }

            Console.Write($"Array of {num}: ");

            foreach (var i in timesArray)
            {
                Console.Write($"{i} ");
            }

        }
    }
}
