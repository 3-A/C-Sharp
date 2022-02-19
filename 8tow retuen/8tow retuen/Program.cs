using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8tow_retuen
{
    class Program
    {   static int ShowNumber(int first , int second ,out int sub)
        {      sub = first - second;      return first * second;               }

        static void ShowNumberr(int first, int second, out int sub)
        {      sub = first - second;       Console.WriteLine( first / second); }
        static void Main(string[] args)
        {
            Console.WriteLine("enter tow no.");
            int f = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());

            int tarh;
            Console.WriteLine(ShowNumber(f, s, out tarh));
            Console.WriteLine(tarh);

            int tarhh;
            ShowNumberr(f, s,out tarhh);
            Console.WriteLine(tarhh);
        }

    }
}
