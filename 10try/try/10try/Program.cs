using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10try
{
    class Program
    {
        static void Main(string[] args)
        {
            start:
            //int x = 2 / int.Parse(Console.ReadLine());     Console.WriteLine(x);
            try
            {
                int x = 2 / int.Parse(Console.ReadLine());
            }

            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine(ex.Source);
            //    Console.WriteLine(ex.TargetSite);
            //    Console.WriteLine(ex.HelpLink);
            //    Console.WriteLine(ex.StackTrace);
            //    Console.WriteLine(ex.Data);
            //}
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
                Console.WriteLine("ok");
            }
        }
    }
}