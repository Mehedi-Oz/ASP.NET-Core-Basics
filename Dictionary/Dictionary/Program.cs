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
                { 1, "Muhammad"},
                { 2, "Mehedi"},
                { 3, "Hasan"}
            };

            //names.Add(1, "Muhammad");
            //names.Add(2, "Mehedi");
            //names.Add(3, "Hasan");

            foreach (var name in names)
            {
                Console.Write($"{name} ");
            }
        }
    }
}
