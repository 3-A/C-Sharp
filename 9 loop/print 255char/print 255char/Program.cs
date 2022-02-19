using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace print_255char
{
    class Program
    {
        static void Main(string[] args)
        {      
            
            for (int i = 0; i < 255; i++)
            {  
                 Console.Write("{0} = {1}\t\t", i, (char)i);
                 if (i % 10 == 0) Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
