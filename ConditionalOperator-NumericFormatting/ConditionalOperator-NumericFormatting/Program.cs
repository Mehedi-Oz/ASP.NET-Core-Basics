using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalOperator_NumericFormatting
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Conditional Operator

            int age = 25;

            string result = age >= 18 ? "Valid" : "Invalid";
            Console.WriteLine(result);

            //Numeric Formatting

            double value = 100D / 12.34D;

            Console.WriteLine(value);
            Console.WriteLine(string.Format("{0:0.00}", value));
            Console.WriteLine(string.Format("{0:0.0}", value));
            Console.WriteLine(string.Format("{0:0.000}", value));

            Console.WriteLine(value.ToString("ToString-C"));
            Console.WriteLine(value.ToString("C"));
            Console.WriteLine(value.ToString("C0"));
            Console.WriteLine(value.ToString("C1"));
            Console.WriteLine(value.ToString("C2"));
            Console.WriteLine(value.ToString("C3"));


            //Specific Culture 
            Console.WriteLine(value.ToString("C", CultureInfo.CurrentCulture));

        }
    }
}
