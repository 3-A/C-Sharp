using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_Loops
{
    class Program
    {
        static void Main(string[] args)
        {/* local variable definition */
            //The following program uses a nested for loop to find the prime numbers from 2 to 100:
            int i, j;

            for (i = 2; i < 1000; i++)
            {
                for (j = 2; j <= (i / j); j++)
                    if ((i % j) == 0) break; // if factor found, not prime
                if (j > (i / j))
                    Console.WriteLine("{0} is prime", i);
            }
              Console.ReadLine();
        }
    }
}
