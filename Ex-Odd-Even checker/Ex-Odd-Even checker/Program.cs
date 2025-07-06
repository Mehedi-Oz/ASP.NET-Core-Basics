using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Odd_Even_checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int checkNumber;
            Console.WriteLine("\n------Check if a number is even or odd------\n");
            Console.Write("Enter a number: ");
            checkNumber = Convert.ToInt32(Console.ReadLine());

            // Check if x is even or odd

            if (checkNumber % 2 == 0)
            {
                Console.WriteLine($"{checkNumber} is a even number");
            }
            else
            {
                Console.WriteLine($"{checkNumber} is a odd number");
            }
        }
    }
}

