using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nested_switch_Statements
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                /* local variable definition */
                char grade = 'A';

                switch (grade)
                {
                    case 'A': Console.WriteLine("Excellent!"); break;
                    case 'B': Console.WriteLine("good"); break;
                    case 'C': Console.WriteLine("Well done"); break;
                    case 'D': Console.WriteLine("You passed"); break;
                    case 'F': Console.WriteLine("Better try again"); break;
                    default: Console.WriteLine("Invalid grade"); break;
                }
                Console.WriteLine("Your grade is  {0}", grade);
                Console.ReadLine();
            }
            
            //int a = 100;
            //int b = 120;

            //switch (a)
            //{         case 100:         Console.WriteLine("This is part of outer switch ");
            //          switch (b) {    case 200:  Console.WriteLine("This is part of inner switch ");    break;   }
            //       break;
            //}
            //Console.WriteLine("Exact value of a is : {0}", a);
            //Console.WriteLine("Exact value of b is : {0}", b);
             Console.ReadLine();
        }
    }
}
