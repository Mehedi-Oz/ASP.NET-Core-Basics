using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Ex_StringInReverse
{

    /*
     * Ask user to input message
     * Print in order
     * Print in reverse
    */

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a message: ");
            string message = Console.ReadLine();

            // This is a message

            Console.WriteLine($"User's given message in order: {message}");
            Console.WriteLine("\nUser's given message in reverse:\n");

            int i = 0;
            for (i = message.Length - 1; i >= 0; i--)
            {
                Console.Write(message[i]);
                System.Threading.Thread.Sleep(200);
            }
        }
    }
}
