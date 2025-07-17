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

            Array.Reverse(numbers);

            Console.Write("\nReversed Array: ");

            foreach (int num in numbers)
            {
                Console.Write($"{num} ");
            }

        }
    }
}
