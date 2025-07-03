using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 25;

            long bigNumber = 472309478L;


            //Console.WriteLine($"Long Number: {bigNumber}");


            Console.WriteLine($"int.MaxValue value is :{int.MaxValue}");
            Console.WriteLine($"int.MinValue value is :{int.MinValue}");
            Console.WriteLine($"long.MaxValue value is :{long.MaxValue}");
            Console.WriteLine($"long.MinValue value is :{long.MinValue}");

            double num = 3.4433;
            Console.WriteLine($"Double value is :{num}");

            float floatNum = 1.4f;
            Console.WriteLine($"Float value is :{floatNum}");

            decimal decimalNum = 1.4M;
            Console.WriteLine($"Decimal value is :{decimalNum}");

            Console.WriteLine("My age is: " + age);
            Console.WriteLine($"My age is: {age}");
        }
    }
}
