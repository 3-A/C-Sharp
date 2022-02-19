using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_class
{ 
    class person
    {
        //fields....1
        string eye;
        string hair;
        //proporty....2
        public string Hair
                                            {     get { return hair; }
                                                  set { hair = value;}
                                            }
        public string Eye                   {
                                                  get { return eye; }
                                                  set { eye = value; }
                                            }
        //methods....3
        public void Work()                 { Console.WriteLine("programmer"); }
        //constructor....4
        public person()                    { eye = "black"; hair = "red"; }
        // overload constructor
        public person(string x , string y) { eye = x; hair = y; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            person aaa = new person();
            Console.WriteLine("aaa.hair := " + aaa.Hair + "  aaa.eye := " + aaa.Eye );    //print from constructor
            person bbb = new person("green","red");
            Console.WriteLine("bbb.hair := "+bbb.Hair +"  bbb.eye :=  "+ bbb.Eye);    //print from overload constructor
            aaa.Work();
            aaa.Eye = "blue";
            Console.WriteLine(aaa.Eye);
            eat(); Console.ReadKey( );

        }
        public static void eat() ////static make function call from other 
        {Console.WriteLine("eat hammm");     }
    }
}
