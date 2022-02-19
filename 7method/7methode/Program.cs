using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7methode
{
    class Program
    {
        // internal void Sum() { } //here see it only in this class
        void Sum() { Console.WriteLine(9+1); }
        static void Summ(int first, int second) { Console.WriteLine(first+second); }//static ues to see method in other class
        static int ShowNumber() { return 2; }
        static void Main(string[] args)
        {   //here method its praivet
            Program ex =new Program();            ex.Sum();
            //here method it static
            Console.WriteLine("enter tow int no.");
            int f  = int.Parse(Console.ReadLine());
            int s  = int.Parse(Console.ReadLine());
            Summ(f ,s ); //if we in other class & we call method write name class as example
            Program.Summ(9999999,1);

            int nu = ShowNumber(); Console.WriteLine(nu); Console.WriteLine(ShowNumber());
          //  Console.WriteLine(Summ()); //not work becaues Summ it's void(only execution code inter function)


        }
    }
}
