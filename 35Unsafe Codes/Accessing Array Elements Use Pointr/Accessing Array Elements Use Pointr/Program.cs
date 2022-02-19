using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accessing_Array_Elements_Use_Pointr
{
    class TestPointer
    {
        public unsafe static void Main()
        {
            int[] list = { 10, 100, 200 };
            fixed (int* ptr = list)
                 /* let us have array address in pointer */
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Address of list[{0}]={1}", i, (int)(ptr + i));
                    Console.WriteLine("Value of list[{0}]={1}", i, *(ptr + i));
                }
            Console.ReadKey();
        }
    }
}