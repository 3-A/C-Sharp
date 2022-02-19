using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//لغة استعلام داخليه لل سي شارب يمكن دمجها مع اكسام ال اسكيوال او مع الكود للسي شارب ومع الكلوكشن 
////LinQ language inner Query in C# can it work with SQL & XML & code C# & use with collection

namespace simpleLinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 30, 10, 2, 5, 6, 4, 7, 4, 9, 1, 5, 8 };
            // var its datatype  its able take any data type as object but object notable take array;
            var lessNumber = from number in numbers where number < 5 select number;
            foreach (var item in lessNumber)     {   Console.WriteLine(item);    }
            var GreatNumber = from number in numbers where number > 25 select number;
            foreach (var item in GreatNumber)    { Console.WriteLine(item);      }
        }
    }
}
