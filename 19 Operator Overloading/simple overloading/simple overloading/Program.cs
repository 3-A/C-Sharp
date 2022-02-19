using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            point p = new point();
            point p1 = new point(3);
            point p2 = new point(3,5);
            point p3 = new point();
            point p4 = new point();
            //p3 =point.add(p1, p2);
            //Console.WriteLine(p3.X);
            //Console.WriteLine(p3.Y);
            //Console.WriteLine(p3.X + p3.Y);
            //p3 = p1 + p2;
            //Console.WriteLine(p3.X);
            //Console.WriteLine(p3.Y);
            //p4 = p1 / p2;
            //Console.WriteLine(p4.X);
            //Console.WriteLine(p4.Y);
            //if (p1 > p2) { Console.WriteLine("True"); }
            //        else { Console.WriteLine("False");}
            p1++; Console.WriteLine(p1.X);Console.WriteLine(p1.Y);
            Console.ReadKey();
        }
    }
}
