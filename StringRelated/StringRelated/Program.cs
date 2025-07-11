using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringRelated
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* ------------------ Verbatim String Literal ----------------- */
            Console.WriteLine("------------------ Verbatim String Literal -----------------\n\n");
            string path = "C:\\AA - GITHUB\\ASP.NET-Core-Basics\\StringRelated";
            Console.WriteLine(path);

            string speech = "He said \"ok\"";
            speech = "He said 'ok'";
            Console.WriteLine(speech);

            //Verbatim String
            path = @"C:\AA - GITHUB\ASP.NET-Core-Basics\StringRelated\n";
            path = @"C:\AA - GITHUB\ASP.NET-Core-Basics\StringRelated" + "\n!!!the escape characters will work here but not in 'Verbatim String'!!!";
            Console.WriteLine(path);

            string name = @"Hasan ""maha""";
            Console.WriteLine(name);


            /* ------------------ String Formatting ({0}) ----------------- */
            Console.WriteLine("\n\n------------------ String Formatting ({0}) -----------------\n\n");
            name = "Hasan";
            int age = 25;

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);

            Console.WriteLine("My Name is " + name + " and my age is " + age);

            Console.WriteLine("My Name is {0} and my age is {1}", name, age);


            /* ------------------ String Interpolation ($) ----------------- */
            Console.WriteLine("\n\n------------------ String Interpolation ($) -----------------\n\n");

            Console.WriteLine($"My Name is {name} and my age is {age}");

            Console.WriteLine(string.Concat("My name is ", name, " and my age is ", age));


            /* ------------------ Empty String ----------------- */
            Console.WriteLine("\n\n------------------       Empty String       -----------------\n\n");

            name = ""; //empty string
            name = string.Empty;

            Console.Write("Enter your name: ");
            name = Console.ReadLine();

            //if (name != "")     
            if (name != string.Empty)
            {
                Console.WriteLine($"Your name is {name}");
            }
            else
            {
                Console.WriteLine("Your name is Empty");
            }


            /* ------------------ String Equals Function ----------------- */
            // == compares the values, but the Equals() fucntion compares both values and memory location

            Console.WriteLine("\n\n------------------ String Equals Function -----------------\n\n");

            string message = "check";
            string compare = "check";

            //if (message == compare)
            if (message.Equals(compare))
            {
                Console.WriteLine("Matched!!");
            }
            else
            {
                Console.WriteLine("Not Matched!!");
            }


            Console.Write("Enter your name: ");
            name = Console.ReadLine();


            if (!name.Equals(""))
            {
                Console.WriteLine($"Your name is {name}");
            }
            else
            {
                Console.WriteLine("Name is invalid!");
            }


            /* ------------------ String Iteration (looping) ----------------- */
            Console.WriteLine("\n\n------------------ String Iteration (looping) -----------------\n\n");

            message = "C# is a language";
            Console.WriteLine(message);

            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
                System.Threading.Thread.Sleep(200);
            }

            bool contains = false;

            for (int i = 0; i < message.Length; i++)
            {
                if (message[i].Equals('C'))
                {
                    contains = true;
                }
            }

            if (contains)
            {
                Console.WriteLine("\n\nFound C in " + message);
            }
            else
            {
                Console.WriteLine("\n\nC is not in " + message);
            }


            /* ------------------ String IsNullOrEmpty function ----------------- */
            Console.WriteLine("\n\n------------------ String IsNullOrEmpty function -----------------\n\n");
        }
    }
}
