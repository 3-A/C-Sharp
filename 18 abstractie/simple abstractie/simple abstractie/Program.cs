using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_abstractie
{
    class Program
    {
        static void Main(string[] args)
        {
            point p = new circle();     //make object from Derived  class(inhertians class)
            p.print();                  //object call function from derived class(inhertians class)
            Console.ReadKey();
        }
        //becuse we have abstract function must be class too abstract,&abstract function implemention in (inhertians class)(circle)
        abstract class point         {   public abstract void print();                                         }
        class circle : point         {   public override void print() { Console.WriteLine("This abstracte"); } }
    }
}
