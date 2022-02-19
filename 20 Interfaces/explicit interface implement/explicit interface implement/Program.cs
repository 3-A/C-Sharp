using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace explicit_interface_implement
{
    interface Printable            { void print();   }
    interface Outputable           { void print();   }
    class MyClass : Printable, Outputable
    {
        public void print()       { Console.WriteLine("Printable.print"); }
        void Outputable.print()   { Console.WriteLine("Outputable.print"); }
    }

    class Test
    {
        static void Main() 
        { 
            MyClass cls = new MyClass(); 
            cls.print();
            ((Outputable)cls).print(); Console.ReadKey();
        }
    }
}