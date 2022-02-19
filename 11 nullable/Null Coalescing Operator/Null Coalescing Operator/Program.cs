using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Null_Coalescing_Operator
{
    class Program
    {
        static void Main(string[] args)
        {/*It is used for converting an operand to the type of another nullable (or not) value type operand,
          * where an implicit conversion is possible.If the value of the first operand is null, 
          * then the operator returns the value of the second operand,
          * otherwise it returns the value of the first operand. The following example explains this:*/
            double? num1 = null;
            double? num2 = 3.14157;
            double num3;
            num3 = num1 ?? 5.34;
            Console.WriteLine(" Value of num3: {0}", num3);
            num3 = num2 ?? 5.34;
            Console.WriteLine(" Value of num3: {0}", num3);
            Console.ReadLine();
        }
    }
}
