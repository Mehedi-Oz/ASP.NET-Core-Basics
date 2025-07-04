using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextDataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello, World!";
            char letter = 'A';

            Console.WriteLine($"This is a string: {text}");
            Console.WriteLine($"This is a char: {letter}");

            Console.Write($"String: ");
            Console.Write(text);

            Console.Write($"char: ");
            Console.Write(letter);

            //Empty String and Char

            string emptyString = "";
            char emptyChar = ' ';
            //char defaultEmptyChar = '\0';


            //String to Int
            string numberstring = "12345";
            int number = Convert.ToInt32(numberstring);
            Console.WriteLine();

            string bigNumberString = "1234543829";
            long bigNumber = Convert.ToInt64(bigNumberString);
            Console.WriteLine($"String to long int: {bigNumberString}");
            Console.WriteLine($"Type of bigNumber: {bigNumber.GetType()}");

            bool value = true;
            Console.WriteLine(value);

        }
    }
}
