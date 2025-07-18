using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Lists*/

            List<int> listNumbers = new List<int>()
            { 1,2,3,4,5,6,7,8,9,10};

            foreach (int number in listNumbers)
            {
                Console.Write($"{number} ");
            }

            Console.WriteLine("\n\n");

            List<int> listNew = new List<int>();

            for (var i = 0; i < 5; i++)
            {
                Console.Write("Enter a number: ");
                listNew.Add(Convert.ToInt32(Console.ReadLine()));
            }

            foreach (var number in listNew)
            {
                Console.Write($"{number} ");
            }

            Console.WriteLine("\nAfter removing position 0");

            listNew.RemoveAt(0);

            foreach (var number in listNew)
            {
                Console.Write($"{number} ");
            }
        }
    }
}
