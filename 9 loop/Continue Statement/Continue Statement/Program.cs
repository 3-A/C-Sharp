﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Continue_Statement
{
    class Program
    {
        static void Main(string[] args)
        {/* local variable definition */
            int a = 10;

            /* do loop execution */
            do
            {
                if (a == 15) { /* skip the iteration */      a = a + 2; continue; }
                Console.WriteLine("value of a: {0}", a);
                a++;

            } while (a < 20);

            Console.ReadLine();
        }
    }
}
