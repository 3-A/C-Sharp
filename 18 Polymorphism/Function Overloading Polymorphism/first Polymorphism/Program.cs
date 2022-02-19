using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_Polymorphism
{
    class Printdata
    {
        void print(int i)        {         Console.WriteLine("Printing int: {0}", i);        }
        void print(double f)     {         Console.WriteLine("Printing float: {0}", f);      }
        void print(string s)     {         Console.WriteLine("Printing string: {0}", s);      }
        static void Main(string[] args)
        {
            Printdata p = new Printdata();
            p.print(5);                              // Call print to print integer
            p.print(500.263);                        // Call print to print float
            p.print("Hello C++");                    // Call print to print string
            Console.ReadKey();
        }
    }
}
