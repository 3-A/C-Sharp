using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pass_Parameter_by_Output
{
    class NumberManipulator
    {
        public void getValue(out int x)
        {
            int temp = 5;
            x = temp;
        }

        static void Main(string[] args)
        {
            NumberManipulator n = new NumberManipulator();
            /* local variable definition */
            int a = 100;

            Console.WriteLine("Before method call, value of a : {0}", a);

            /* calling a function to get the value */
            n.getValue(out a);

            Console.WriteLine("After method call, value of a : {0}", a);
            Console.ReadLine();

        }
    }
}
