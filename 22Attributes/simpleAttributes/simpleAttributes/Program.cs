using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleAttributes
{
    class Program
    {
        [Obsolete("Message",false)]
        static void Do() { Console.WriteLine("ASDF"); }

        [AttributeUsage(AttributeTargets.All,AllowMultiple =true,Inherited =true)]
        class Neww : Attribute
        {
            public Neww(string messsage) { this.message = message; }//here ues (((this))) to get it pravit filed
            string message; //pravit field 

            public string Message    {   get   {  return message;     }
                                         set   {  message = value;    }
                                     }
        }
        static void Main(string[] args)
        {
            Do();
        }
    }
}
