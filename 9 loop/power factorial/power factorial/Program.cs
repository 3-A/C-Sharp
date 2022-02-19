using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace power_factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter fact or power" );
            string x = Console.ReadLine();
            switch (x)
            {
                case "power" :
                               Console.WriteLine("enter no");
                               int p =Int32.Parse(Console.ReadLine());
                               Console.WriteLine("enter power");
                               int n = Int32.Parse(Console.ReadLine());
                               int result = 1;
                               for (int i = 1; i <= n; i++)   {     result = result * p;}
                               Console.WriteLine(result);
                               break;
                case "fact": 
                                Console.WriteLine("enter no");
                                int f = Int32.Parse(Console.ReadLine());
                                int result1 = 1;
                                for (int i = 1; i <= f; i++)  {     result1 = result1 * i; }
                                Console.WriteLine(result1);
                                break;
                default:break ;
            }
            Console.ReadKey();
        }

    }
}
