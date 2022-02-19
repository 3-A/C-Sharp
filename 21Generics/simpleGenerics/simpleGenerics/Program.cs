using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleGenerics
{
    class Program
    {
        static int[] Sort(int[] arr) { Array.Sort(arr); return arr; }
        static double[] Sort(double[] arr) { Array.Sort(arr); return arr; }
        static void Sort<T>(T[] arr) { Array.Sort(arr); }// Console.WriteLine(arr);return arr;
        static void Main(string[] args)
        {
              //ArrayList x  = new ArrayList();       x.Add("qqqq"); x.Add(890); x.Add('f'); x.Add(5.7);
              //Sort<>(x);                      foreach (var item in x) { Console.WriteLine(item); }

            string[] xx = { "www", "qqqq", "ffff", "aaaa", "eeee" };
            Sort<string>(xx);
            foreach (var item in xx)            {     Console.WriteLine(item);       }
        }
    }
}
