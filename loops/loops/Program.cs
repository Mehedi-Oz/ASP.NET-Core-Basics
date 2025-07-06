using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;

            //For loop 
            Console.WriteLine("\n----For Loop----\n");
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            // While loop
            Console.WriteLine("\n----While Loop----\n");

            i = 0;

            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }

            // Do-While loop

            i = 0;
            Console.WriteLine("\n----Do-While Loop----\n");

            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 5);
        }
    }
}
