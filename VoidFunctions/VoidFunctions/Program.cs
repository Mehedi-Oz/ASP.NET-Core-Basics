using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (int.TryParse("123", out int result))
            {
                Console.WriteLine(result);
            }
        }
    }
}
