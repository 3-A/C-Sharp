using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pointer_by_ref
{
    class Program
    {
        public static void incrment(ref int y) { y++; }
        static void Main(string[] args)        { int x = 5; incrment(ref x); Console.WriteLine(x); }
        //public static void incrment(  int y) { y++; }
        //static void Main(string[] args)      { int x = 5; incrment( x); Console.WriteLine(x); }
    }
}
