using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_space
            {
                 class namespace_cl  {    public void func()  { Console.WriteLine("Inside first_space"); }   }
            }
namespace second_space
            {
                 class namespace_cl  {    public void func()  { Console.WriteLine("Inside second_space"); }  }
            }
class TestClass
{
    static void Main(string[] args)
    {
        first_space.namespace_cl fc = new first_space.namespace_cl();        fc.func();
        second_space.namespace_cl sc = new second_space.namespace_cl();      sc.func();
        Console.ReadKey();
    }
}