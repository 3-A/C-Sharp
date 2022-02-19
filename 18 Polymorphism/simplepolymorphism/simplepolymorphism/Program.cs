using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simplepolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            point p = new point();           p.print();
            circle c = new circle();         c.print();
            Console.ReadKey();
        }
    }
    class point          { public virtual void print()  { Console.WriteLine("This is class point"); } }

    class circle : point { public override void print() { Console.WriteLine("This is class circle"); } }
}
