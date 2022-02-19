using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleinterface
{
    class Program
    {
        static void Main(string[] args)
        {
            x xx = new y();
            xx.cal();
            y hh = new y();
            x kk = (x)hh;//make castting hh on interface x &put hh object in kk object;
            //hh.cal();//not work?
            kk.cal();
            Console.ReadKey();
        }
        //here we not ues abstract .
        //use interface have condetion abstract
        interface x
        {//in interface &abstract can'nt defeind field &implement function
           void cal();
           int c {get;set;}//defeind field as propertie
        }
        class y : x
        {
            void x.cal() { Console.WriteLine("here interface"); }
            //implement field
            int aa;
            int x.c { get { return aa; } set { aa = value; } }
        }
    }
}
