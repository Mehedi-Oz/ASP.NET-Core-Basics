using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Array Sorting*/

            int[] numbers = new int[]
            {
                4,5,23,6,7,234,9,2,0, 3
            };

            Console.Write("Unsorted Array: ");

            foreach (int num in numbers)
            {
                Console.Write($"{num} ");
            }

            Array.Sort(numbers);

            Console.Write("\nSorted Array: ");

            foreach (int num in numbers)
            {
                Console.Write($"{num} ");
            }


            /*Array Reverse*/

            //Array.Reverse(numbers);

            //Console.Write("\nReversed Array: ");

            //foreach (int num in numbers)
            //{
            //    Console.Write($"{num} ");
            //}

            //Another Way to Reverse Array

            int[] sortedArray = new int[numbers.Length];

            int x = 0;

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                sortedArray[x] = numbers[i];
                x++;
            }

            Console.Write("\nReversed Array: ");

            foreach (var num in sortedArray)
            {
                Console.Write($"{num} ");
            }


            /*Array Clearing*/


            Array.Clear(numbers, 2, 5);

            //Alternative of Array.Clear
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = default;
            }

            Console.Write("\nCleared Array: ");

            foreach (var num in numbers)
            {
                Console.Write($"{num} ");
            }


            /*Array IndexOf*/

            Console.Write("\nSorted Array: ");
            foreach (var num in sortedArray)
            {
                Console.Write($"{num} ");
            }

            Console.Write("\nEnter a Number to Search: ");

            int search = Convert.ToInt32(Console.ReadLine());

            //int position = Array.IndexOf(sortedArray, search);

            int position = Array.IndexOf(sortedArray, search, 0, 5);

            if (position > -1)
            {
                Console.WriteLine($"{search} is found at position {position + 1}");
            }
            else
            {
                Console.WriteLine($"{search} is not present in the array!");
            }
        }
    }
}
