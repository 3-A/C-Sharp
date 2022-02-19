using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simplecollections
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(7);
            list.Add('K');

            Queue q = new Queue();
            q.Enqueue(99);

            Hashtable h = new Hashtable();
            h.Add("a", 5);
            h.Add("b", 10);

            Console.WriteLine(h["a"]);
            Console.WriteLine(h["m"]);

            System.Collections.Specialized.StringDictionary ddd = new System.Collections.Specialized.StringDictionary();
            ddd.Add("i", "iiii");
           
        }
    }
}
