using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_simple
{ 
    class circle : rectangle
    {   //fields
        int x; int y;//private not acsses only form function same class
        //property
        public int X                   {     get { return x; }           set { x = value; }        } 
        public int Y                   {     get { return y; }           set { y = value; }        }
       //method
        public void area(int x, int y) { Console.WriteLine(x*y); }
    }
    class rectangle
    {
        private int z;
        public int Z                  {    get { return z; }     set { z = value; }      }
        public void print( int x )    { Console.WriteLine(x); }
    }
    
    
    class Program
    {
        static void Main(string[] args)
        {
            rectangle r = new rectangle();
            circle c = new circle();
            c.area(2, 4);
            r.print(3);
            c.print(5);
            Console.ReadKey();
        }
    }
}
