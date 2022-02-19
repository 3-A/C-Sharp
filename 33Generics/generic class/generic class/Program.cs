using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic_class
{
    class Program
    {
        static void Main(string[] args)
        {
            point<int> p = new point<int>(1000);
            point<string> dd = new point<string>("VVV");
            Console.ReadKey();
        }
    }
    //<T>mean alldata type
    class point <T>
    {
        T sum;
        //constructor
        public point(T x) { Console.WriteLine("type element:{0} value:{1}",typeof (T),x); }

    }
}
