using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreateAndPrintArray();
        }

        static void CreateAndPrintArray()
        {
            int[] numbers = new int[3] { 0, 1, 2 };

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}