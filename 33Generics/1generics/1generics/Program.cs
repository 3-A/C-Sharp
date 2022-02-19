using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1generics
{
    class Program
    {   //static give him call function from main without calss
        //<T> main accsept all data type
        public static void print<T>(T  x)       {        Console.WriteLine("type of element {0}   value ={1} ", typeof(T),x);      }
        static void Main(string[] args)
        {
            print(5.98898); //here function int
            print("aaaa");//here functiom string
            Console.ReadKey();
        }
    }
}
