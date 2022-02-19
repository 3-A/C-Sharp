using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nullable_types
{
    class Program
    {
        static void Main(string[] args)
        {
         int? num1 = null;
         int? num2 = 45;
         double? num3 = new double?();
         double? num4 = 3.14157;
         
         bool? boolval = new bool?();

         // display the values
          Console.WriteLine("Nullables at Show: {0}, {1}, {2}, {3}", num1, num2, num3, num4);
        Console.WriteLine("Nullables at Show1:  {0}",num1);
        Console.WriteLine("Nullables at Show2:  {0}",num2);
        Console.WriteLine("Nullables at Show3:  {0}",num3);
        Console.WriteLine("Nullables at Show4:  {0}",num4);

        Console.WriteLine("A Nullable boolean value: {0}", boolval);
         Console.ReadLine();

        }
    }
}
