using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Param_Arrays
{ class ParamArray
   {
    public int summ(params int[] arr)
    {
        int sum = 0;
        foreach (int i in arr) { sum += i; }
        return sum;
    }
        static void Main(string[] args)
        {
            ParamArray app = new ParamArray();
         int sum = app.summ(512, 720, 250, 567, 889);
         Console.WriteLine("The sum is: {0}", sum);
         Console.ReadKey();
        }
   }
}
