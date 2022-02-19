using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class MainClass
{
    [Obsolete("Use myMeth2, instead.")]
    static int myMethod(int a, int b)    {        return 0;    }
    // Improved version of myMethod. 
    static int myMethod2(int a, int b)    {        return 1;    }
    public static void Main()             {
        Console.WriteLine("4 / 3 is " + myMethod(4, 3));         // warning displayed for this 
        Console.WriteLine("4 / 3 is " + myMethod2(4, 3));        // no warning here 
    }
}
