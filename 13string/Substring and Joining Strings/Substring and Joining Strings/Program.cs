using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substring_and_Joining_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Last night I dreamt of San Pedro";
            Console.WriteLine(str);
            string substr = str.Substring(23);
            Console.WriteLine(substr);
            string[] starray = new string[]{"Down the way nights are dark", "And the sun shines daily on the mountain top",
         "I took a trip on a sailing ship","And when I reached Jamaica","!@#$%^&*()_+","!@#$%^&*)(_+","!№;%:?*()_AppDomain+"};

         string strr = String.Join("\n", starray);
         Console.WriteLine(strr);
         Console.ReadKey();
        }
    }
}
