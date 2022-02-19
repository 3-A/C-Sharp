using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace list_simple
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> x = new List<string>();
            x.Add("AAA");
            x.Add("WWW");
            x.Add("ZZZ");
            foreach (string s in x) { Console.WriteLine(s); }
            Console.ReadKey();
        }
    }
}
