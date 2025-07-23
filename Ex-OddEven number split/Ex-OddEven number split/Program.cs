using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_OddEven_number_split
{
    internal class Program
    {

        /*
         * Create two lists with integer data type,
         * Loop from 0-20
         * one for even numbers, one for odd
            * if number is even, add to even list
            * if number is odd, add to odd list
         * Print even list
         * Print odd list
         */

        static void Main(string[] args)
        {
            List<int> evenList = new List<int>();
            List<int> oddList = new List<int>();

            for (var i = 0; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    evenList.Add(i);
                }
                else
                {
                    oddList.Add(i);
                }
            }

            Console.WriteLine("Even Numbers: \n");

            foreach (var i in evenList)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine("\n\nOdd Numbers: \n");

            foreach (var i in oddList)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine("\n");
        }
    }
}
