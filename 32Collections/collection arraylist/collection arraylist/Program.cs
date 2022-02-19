using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
//array list use to collect element form difrentes type;
namespace collection_arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList x = new ArrayList();
            x.Add(3930);
            x.Add("sdsds");
            x.Add('W');
            foreach (object s in x) { Console.WriteLine("itme of array s :{0}",s); }
            Console.ReadKey();
        }
    }
}
