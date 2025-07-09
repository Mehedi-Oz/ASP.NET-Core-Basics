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
            Console.Write("Enter a number: ");
            string inputNumber = Console.ReadLine();

            int num = 0;

            bool success = int.TryParse(inputNumber, out num);

            if (success)
            {
                Console.WriteLine($"{inputNumber} is converted to {num} successfully!!!");
            }
            else
            {
                Console.WriteLine("Invalid number format. Failed to convert!");
                Console.WriteLine($"{inputNumber} is not converted to int value successfully!!!");
            }

        }
    }
}
