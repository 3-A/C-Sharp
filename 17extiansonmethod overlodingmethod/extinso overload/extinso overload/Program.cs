using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extinso_overload
{
    static class work
    { //extinsion method must write in static class & here must be static
        public static string DoWork(this int number)
        { return "The string for the number is " + number*number; }
        //method overload
        public static string DoWork(this int number,string message)
        { return message + " " + number; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int num = 4; Console.WriteLine(num.DoWork());
                         Console.WriteLine(num.DoWork("I put message"));
            Console.ReadLine();

        }
    }
}
