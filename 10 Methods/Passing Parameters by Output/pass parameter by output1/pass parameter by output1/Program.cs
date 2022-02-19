using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace pass_parameter_by_output1
{
    class NumberManipulator
    {
        public void getValues(out int x, out int y)
        {
            Console.WriteLine("Enter the first value: ");     x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second value: ");    y = Convert.ToInt32(Console.ReadLine());
        }
        public int mult(int n, int m) { return n * m; }
        static void Main(string[] args)
        {
            NumberManipulator n = new NumberManipulator();
            /* local variable definition */                  int a, b;
            /* calling a function to get the values */       n.getValues(out a, out b);

            Console.WriteLine("After method call, value of a : {0}", a);
            Console.WriteLine("After method call, value of b : {0}", b);
            int tt; tt = n.mult(a, b);    Console.WriteLine("After method call, value of mult : {0}", tt);
            Console.ReadLine();
        }
    }
}