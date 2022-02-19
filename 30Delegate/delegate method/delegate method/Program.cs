using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate_method
{
    class Program
    {
        public delegate double work(int a,int b);
        static void Main(string[] args)
        {
            double r1, r2;
            work aaa = new work(multi);    r1 = aaa(4, 3);   Console.WriteLine(r1);
            aaa = new work(add);           r2 = aaa(4, 3);   Console.WriteLine(r2); 
            Console.ReadKey();
        }
        public static double multi(int a, int b) { return(a * b); }
        public static double add(int a, int b) { return(a + b); }
    }
}
