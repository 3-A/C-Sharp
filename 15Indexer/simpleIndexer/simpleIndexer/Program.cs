using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleIndexer
{   
    class Employee
    {
        int[] _No   = new int[100];
        string[] _Name = new string[100];

        //public int this[string index]
        //{
        //    get { return __No[index]; }
        //    set { _No[value ] = value ; }
        //}
        public string this [int index]   
        {
            get        {   return _Name[index] ;       }
            set        {  _Name[index]  = value ;      }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee empl = new Employee();
            empl[10] = "gggggggyyyyyyyy0";
            Console.WriteLine(empl[10]);
        }
    }
}
