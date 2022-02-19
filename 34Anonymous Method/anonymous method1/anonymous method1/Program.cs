using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//namespace anonymous_method1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {   int[] x = { 1, 2, 3, 4, 5, 6, 7 };
//            int[] y = Array.FindAll(x,iseven);
//            foreach (int z in y) { Console.WriteLine(z); }
//            Console.ReadLine();
//        }
//           private static bool iseven(int obj)     {    return(obj % 2 ==1);    }      
//    }
//}
namespace anonymous_method1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 1, 2, 3, 4, 5, 6, 7 };
            int[] y = Array.FindAll     (x, delegate(int obj) { return (obj % 2 == 1); }    );//this anonymous method
            foreach (int z in y)        { Console.WriteLine(z); }
            Console.ReadLine();
        }
    }
}