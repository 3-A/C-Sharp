using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Polymorphism
{
    abstract class Shape                              {      public abstract int area();       } //constructor
    class Rectangle : Shape
    {
        private int length;
        private int width;
        public Rectangle(int a = 0, int b = 0)        {      length = a;     width = b;         }
        public override int area()                    {      Console.WriteLine("Rectangle class area :");   return (width * length);   }
    }

    class RectangleTester
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(10, 7); Rectangle rr = new Rectangle(); Rectangle rrr = new Rectangle(10);
            double a = r.area();              Console.WriteLine("Area: {0}", a);
            double b = rr.area();             Console.WriteLine("Area: {0}", b);
            double c = rrr.area();            Console.WriteLine("Area: {0}", c);
            Console.ReadKey();
        }
    }
}
