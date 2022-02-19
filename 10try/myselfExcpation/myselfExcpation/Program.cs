using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfExcpation
{
    class Program
    {
        static void Main(string[] args)
        {
            start:
            //int x = 2 / int.Parse(Console.ReadLine());     Console.WriteLine(x);
            try
            {
                int y = int.Parse(Console.ReadLine());
                if (y == 2)     { throw new Exception(); }//my Exception
                int x = 2 / y;
            }

            
            catch (Exception eee)
            {
                Console.WriteLine(eee.Message);
                //Console.WriteLine(eee.Source);
                //Console.WriteLine(eee.TargetSite);
                //Console.WriteLine(eee.HelpLink);
                //Console.WriteLine(eee.StackTrace);
                //Console.WriteLine(eee.Data);
                goto start;
            }
            finally
            {
                Console.WriteLine("OK");
            }
        }
    }
}
