using System;
using first_space;
using second_space;

namespace first_space
           {
           class aaa {    public void func()  { Console.WriteLine("Inside first_space"); }   }
           }
namespace second_space
           {
           class bbb {    public void func()  { Console.WriteLine("Inside second_space");}   }
           }
class TestClass
{
    static void Main(string[] args)
    {
        aaa fc = new aaa(); fc.func();
        bbb sc = new bbb(); sc.func();
        Console.ReadKey();
    }
}
