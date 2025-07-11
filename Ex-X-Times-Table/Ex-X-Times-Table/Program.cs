using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_X_Times_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int inputNumber = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                //Console.WriteLine($"{i} x {inputNumber} = {i * inputNumber}");
                Console.WriteLine("{0} x {1} = {2}", i, inputNumber, i * inputNumber);
            }

            Console.WriteLine("Finished!");
        }
    }
}
