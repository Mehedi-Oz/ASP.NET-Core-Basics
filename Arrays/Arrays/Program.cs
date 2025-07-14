using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write("Enter a number: ");
            //    numbers[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //Console.Write("\nNumbers Array: ");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write($"{numbers[i]} ");
            //}

            //Console.Write("\nNumbers Array: ");
            //foreach (int num in numbers)
            //{
            //    Console.Write($"{num} ");
            //}


            //Triangle Exercise

            const int angleCount = 3;
            int[] angleArray = new int[angleCount];
            int angleSum = 0;

            for (int i = 0; i < angleCount; i++)
            {
                Console.Write($"Enter Angle {i + 1}: ");
                angleArray[i] = Convert.ToInt32(Console.ReadLine());

                angleSum += angleArray[i];
            }

            if (angleSum == 180)
            {
                Console.WriteLine("Vaild!");
            }
            else
            {
                Console.WriteLine("Invaild!");
            }

        }
    }
}
