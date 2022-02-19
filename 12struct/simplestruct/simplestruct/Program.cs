using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//struct (value type named when take object of struct it's variable block in RAM(stack) )
//class (reference type named when take object of class it's variable block in RAM(heap) )
namespace simplestruct
{ //struct used for light work (Heavy work ues class)
    struct TheStruct
    {
        #region figuer struct 
        //not write constructor without parameter
        //public TheStruct(int num1, int num2) { Nunber1 = 0; Nunber2 = 0; }
        //if we write field(variable) we must assign value
        //public int Nunber1;
        //public int Nunber2;
        #endregion
        public int s ;
    }
    class TheClass
    {
        public int c;
    }
    class Program
    {
        static void StructMethod(TheStruct structParamter)
        { structParamter.s = 10; }
        static void ClassMethod(TheClass classParamter)
        { classParamter.c = 5; }
        static void Main(string[] args)
        {
            TheStruct structobject = new TheStruct();
            TheClass classobject = new TheClass();

            structobject.s = 1000;
            classobject.c = 555;

            Console.WriteLine("structobject.s = {0}", structobject.s);
            Console.WriteLine("classobject.c = {0}", classobject.c);

            StructMethod(structobject);
            ClassMethod(classobject);

            Console.WriteLine("Method structobject.s = {0}", structobject.s);
            Console.WriteLine("Method classobject.c = {0}", classobject.c);
        }
    }
}
