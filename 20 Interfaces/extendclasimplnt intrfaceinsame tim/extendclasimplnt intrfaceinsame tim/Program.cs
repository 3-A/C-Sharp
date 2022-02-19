using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//extend class and implement interface at the same time
namespace extendclasimplnt_intrfaceinsame_tim
{
    public class Component    {        public Component() { }           }
    interface Printable       {        void printHeader(float factor);
                                       void printFooter(float factor);
                              }

    public class TextField : Component, Printable
    {
        public TextField(string text)                { this.text = text; Console.WriteLine(text); }
        // implementing Printable.printHeader()
        public void printHeader(float factor)        { Console.WriteLine(factor); }
        // implementing Printable.printFooter()
        public void printFooter(float factor)        { Console.WriteLine(factor); }
        private string text;
    }
    class Program
    {
        static void Main(string[] args)
        {
            TextField text = new TextField("Hello");
            Printable aaa = (Printable)text;
            aaa.printHeader(0.5F);
            aaa.printFooter(0.00001F);        Console.ReadKey();
        }
    }
}
