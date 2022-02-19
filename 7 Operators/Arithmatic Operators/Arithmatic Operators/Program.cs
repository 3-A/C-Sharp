using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmatic_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            int b = 10;
            int c;

            c = a + b; Console.WriteLine("Line 1 - c = a + b is {0}", c);
            c = a - b; Console.WriteLine("Line 2 - c = a - b is {0}", c);
            c = a * b; Console.WriteLine("Line 3 - c = a * b is {0}", c);
            c = a / b; Console.WriteLine("Line 4 - c = a / b is {0}", c);
            c = a % b; Console.WriteLine("Line 5 - c = a % b is {0}", c);
            c = a++;   Console.WriteLine("Line 6 - c = a++   is {0}", c);
            c = a--;   Console.WriteLine("Line 7 - c = a--   is {0}", c);
            Console.ReadLine();
        }
    }
}
