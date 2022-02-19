using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handli
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {//here write code which thing have wrong;
               // int x=0;  x++;
                string s = null;
                s.ToLower();

            }catch(Exception ex) //here we take object named ex from error up;
            {//here error input in ex
                Console.WriteLine(ex.ToString());//
            }

            finally
            {
                Console.WriteLine("C#");
            }

        }
    }
}
