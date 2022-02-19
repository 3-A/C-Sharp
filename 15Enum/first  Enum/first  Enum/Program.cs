using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first__Enum
{
    class Program
    {
        enum Days            { Sun, Mon, tue, Wed, thu, Fri, Sat } 
        enum Colors          { red,  blue,  green, yellow        }
        enum Volume          {   Low,       Medium,        High  }
        static void Main(string[] args)
        {
            int WeekdayStart = (int)Days.Mon; Console.WriteLine("Monday: {0}", WeekdayStart);
            int WeekdayEnd = (int)Days.Fri;   Console.WriteLine("Friday: {0}", WeekdayEnd);
           
            string inVal = "green";
            Colors newColor = (Colors)Enum.Parse(typeof(Colors), inVal);
            //Check the Enum type
            if (newColor == Colors.green)    {   Console.WriteLine(newColor.ToString());  }

            Console.WriteLine("put xx and initialize instance of enum type Low,Medium,High");

            string xx = Console.ReadLine();
            Volume myVolume = (Volume)Enum.Parse(typeof(Volume), xx);/* put xx and initialize instance of enum type*/  
            switch (myVolume)   {
                                 case Volume.Low:    Console.WriteLine("The volume has been turned Down."); break;
                                 case Volume.Medium: Console.WriteLine("The volume is in the middle.");     break;
                                 case Volume.High:   Console.WriteLine("The volume has been turned up.");   break;
                                 default: Console.WriteLine("your entering invalid"); break;
                                }
             Console.ReadKey();
        }
    }
}
