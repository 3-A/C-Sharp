using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6LOOP
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Hello World!");

            string[] names = { "aaaaaa", "bbbb", "cccccc", "ddddd", "eeee" };
            string[] newnames = new string[4];
            newnames[0] = "ahmed";
            newnames[1] = "riad";
            newnames[2] = "kamal";
            newnames[3] = "Tamer";
            #region case
            Console.WriteLine("no:="); int no = int.Parse(Console.ReadLine());
            switch (no)
            {
                case 1: Console.WriteLine(1); break;
                case 2: Console.WriteLine(2); break;
                case 3: Console.WriteLine(3); break;
                case 4:
                case 5:
                case 6:
                case 7: Console.WriteLine(456); break;
                default: Console.WriteLine(0000); break;
            }
            #endregion
            #region for
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i + "  God");
            }
            #endregion
            #region foreach
            foreach (string item in names)
            {
                Console.WriteLine(item);
            }
            #endregion
            #region while
            while (Console.ReadLine() == "a")
            {
                Console.WriteLine("yes");
            }
            #endregion
            #region do
            do
            {
                Console.WriteLine("yes");
            }
            while (Console.ReadLine() == "a");
            #endregion

            Console.ReadKey();

        }
    }
}
