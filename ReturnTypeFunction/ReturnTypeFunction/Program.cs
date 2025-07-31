using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnTypeFunction
{
    internal class Program
    {
        /* Return Type Functions */

        static string name = "Hasan";

        static void Main(string[] args)
        {
            Console.Title = "Return Type Functions";

            PrintIntroduction();

            //ReturnName();

            int[] numbers = new int[3];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = ReadNumberFromConsole();
            }

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("Array");

            int[] newNumbers = CreateRandomArray();
            foreach (var num in newNumbers)
            {
                Console.WriteLine(num);
            }

            Console.ReadLine();
        }

        static int[] CreateRandomArray()
        {
            int[] numbers = new int[3]
            {   0,
                1,
                2
            };

            return numbers;
        }

        static int ReadNumberFromConsole()
        {
            Console.Write("Enter a number: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static string ReturnName()
        {
            return name;
        }

        static void PrintIntroduction()
        {
            Console.WriteLine(ReturnName());
        }
    }
}
