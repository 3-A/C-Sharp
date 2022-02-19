using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9commndoutfromprogr
{
    class Program
    {
        static void Main(string[] args)
        {
             beg:
            for (int i = 0; i < 3; i++)
            {
                for (int ii = 0; ii < 50; ii++) { Console.Write("*"); }
                Console.WriteLine(" ");
            }
            while(Console.ReadLine() != "c")   { goto beg; }

        }
    }
}
