using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleevent
{
    class Program
    {
        //defein delegate
        public delegate void Mydelegate();
        //defein my event
        public event Mydelegate MyEvent;
        static void Main(string[] args)
        {
            Program p = new Program();
          //   p.MyEvent += P_MyEvent;
            if (p.MyEvent != null)
            { p.MyEvent.Invoke(); }
            //p.MyEvent += P_MyEvent;
            //p.MyEvent.Invoke();
        }

        private static void P_MyEvent()
        {
            Console.WriteLine("Event Raised");
        }
    }
}
