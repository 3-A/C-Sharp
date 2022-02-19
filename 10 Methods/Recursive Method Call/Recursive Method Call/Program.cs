using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Recursive_Method_Call
{
    class NumberManipulator
    {
        public int factorial(int num)
        {    /* local variable declaration */
            int result;
            if   (num == 1)  { return 1;                                            }
            else             { result = factorial(num - 1) * num; return result;    }
        }
        static void Main(string[] args)
        {
            NumberManipulator n = new NumberManipulator();
            //calling the factorial method\\4=1*2*3*4=24//
            Console.WriteLine("Factorial of 1 is : {0}", n.factorial(1));
            Console.WriteLine("Factorial of 2 is : {0}", n.factorial(2));
            Console.WriteLine("Factorial of 3 is : {0}", n.factorial(3));
            Console.WriteLine("Factorial of 4 is : {0}", n.factorial(4));
            Console.WriteLine("Factorial of 5 is : {0}", n.factorial(5));
            Console.WriteLine("Factorial of 6 is : {0}", n.factorial(6));
            Console.WriteLine("Factorial of 7 is : {0}", n.factorial(7));
            Console.WriteLine("Factorial of 8 is : {0}", n.factorial(8));
            Console.WriteLine("Factorial of 9 is : {0}", n.factorial(9));
            Console.WriteLine("Factorial of 10 is: {0}", n.factorial(10));
            Console.ReadLine();
        }
    }
}