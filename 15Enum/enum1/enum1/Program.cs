using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum1
{
    class Program
    {
        //enum week { sat,sun,mon,tus,wed,thr,fri}
        enum week { sat=100, sun, mon, tus, wed, thr, fri }
        static void Main(string[] args)
        {
            int x = (int)week.tus;
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
