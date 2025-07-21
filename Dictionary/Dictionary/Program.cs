using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Dictionary*/

            Dictionary<int, string> names = new Dictionary<int, string>()
            {
                { 34, "Muhammad"},
                { 63, "Mehedi"},
                { 234, "Hasan"}
            };

            //names.Add(1, "Muhammad");
            //names.Add(2, "Mehedi");
            //names.Add(3, "Hasan");

            foreach (var name in names)
            {
                Console.Write($"{name} ");
            }

            Console.WriteLine("\n");

            for (int i = 0; i < names.Count; i++)
            {
                KeyValuePair<int, string> pair = names.ElementAt(i);
                Console.Write($"{pair.Key} - {pair.Value} ");
            }

            Console.WriteLine("\n");

            foreach (KeyValuePair<int, string> item in names)
            {
                Console.Write($"{item.Key} - {item.Value} ");
            }

            Dictionary<string, string> teachers = new Dictionary<string, string>()
            {
                { "CSE", "Hasan"},
                { "EEE", "Maha" }
            };

            Console.WriteLine("\n");

            //Console.WriteLine(teacher["CSE"]);

            if (teachers.TryGetValue("CSE", out string teacher))
            {
                Console.WriteLine(teacher);
            }
            else
            {
                Console.WriteLine("Not found!");
            }

            Console.WriteLine("\n");

            teachers["CSE"] = "Ok";

            foreach (var x in teachers)
            {
                Console.Write($"{x} ");
            }

            teachers.Remove("EEE");

            Console.WriteLine();

            foreach (var x in teachers)
            {
                Console.Write($"{x} ");
            }
        }
    }
}
