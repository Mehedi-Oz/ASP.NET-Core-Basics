using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool success = true;

            while (success)
            {
                Console.Write("Enter a number: ");
                string inputNumber = Console.ReadLine();

                if (int.TryParse(inputNumber, out int num))
                {
                    success = false;
                    Console.WriteLine($"{inputNumber} is converted to {num} successfully!!!\n");
                }
                else
                {
                    Console.WriteLine("Invalid number format. Failed to convert!!!");
                    Console.WriteLine($"{inputNumber} is not converted to int value successfully!!!\n");
                }
            }
        }
    }
}
