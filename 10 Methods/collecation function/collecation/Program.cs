using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collecation
{
    class Program
    {
        public static void collect(int x,int y,out int sum,out int minus,out int multi,out int div)
        {   sum = x + y;
            minus = x - y;
            multi = x * y;
            div = x / y;
        }
        static void Main(string[] args)
        {  int sum, minus,multi,div;
         collect(25,5,out  sum,out  minus,out multi,out div);
         Console.WriteLine(sum); Console.WriteLine(minus);
         Console.WriteLine(multi); Console.WriteLine(div); Console.ReadKey();
        }
    }
}
