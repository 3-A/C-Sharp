using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace valuerefernull
{
    class Program
    {
        static public int ChangeX (int y) { return y*=10; }//here result save in stack 
        static public int ChangeX(ref int y) { return y *= 10; }//here result save in heap
        static void Main(string[] args)
        {
            Console.WriteLine("Enter int No.");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(ChangeX( x));
            Console.WriteLine(x);// display result x becuas ref x in stack 
            Console.WriteLine(ChangeX(ref x));
            Console.WriteLine(x);// display result ref x becuas ref x in heap 
            //explien nullable
            int? s = null  ;      if (s.HasValue)    { Console.WriteLine("s",true);      }
            int? sss = 0;         if (sss.HasValue)  { Console.WriteLine("   sss ",true); }
            Console.WriteLine(s);
            Console.WriteLine(sss);
        }
    }
}
