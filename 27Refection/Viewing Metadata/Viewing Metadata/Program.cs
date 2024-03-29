﻿//We have mentioned in the preceding chapter that using reflection you can view the attribute information.
//The MemberInfo object of the System.Reflection class needs to be initialized for discovering 
//the attributes associated with a class. To do this, you define an object of the target class, as:
//System.Reflection.MemberInfo info = typeof(MyClass);
//The following program demonstrates thisusing System;
//In this example, we use the DeBugInfo attribute created in the previous chapter and 
//use reflection to read metadata in the Rectangle class.

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System;
namespace BugFixApplication
{
    //a custom attribute BugFix to be
    //assigned to a class and its members
    [AttributeUsage(AttributeTargets.Class |   AttributeTargets.Constructor |  AttributeTargets.Field |   AttributeTargets.Method | AttributeTargets.Property,   AllowMultiple = true)]
    public class DeBugInfo : System.Attribute
    {
        private int bugNo;
        private string developer;
        private string lastReview;
        public string message;

        public DeBugInfo(int bg, string dev, string d)       {   this.bugNo = bg;   this.developer = dev;   this.lastReview = d;      }
        public int BugNo                                     {        get    {         return bugNo;      }                           }
        public string Developer                              {        get    {         return developer;  }                           }
        public string LastReview                             {        get    {         return lastReview; }                           }
        public string Message                                {        get    {         return message;    }
                                                                      set    {         message = value;   }
                                                             }
    }
    [DeBugInfo(45, "Zara kli", "12/8/2012", Message = "Return type mismatch")]
    [DeBugInfo(49, "Nuha Nli", "10/10/2012", Message = "Unused variable")]

    class Rectangle
    {
        //member variables
        protected double length;
        protected double width;
        public Rectangle(double l, double w)                {         length = l;         width = w;        }
        [DeBugInfo(55, "Zara Oli", "19/10/2012", Message = "Return type mismatch")]
        public double GetArea()                             {         return length * width;                }
        [DeBugInfo(56, "Zara Lli", "19/10/2012")]
        public void Display()                              {
                                                              Console.WriteLine("Length: {0}", length);
                                                              Console.WriteLine("Width: {0}", width);
                                                              Console.WriteLine("Area: {0}", GetArea());
                                                           }
    }//end class Rectangle
    class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(4.5, 7.5);
            r.Display();
            Type type = typeof(Rectangle);

    //iterating through the attribtues of the Rectangle class
            foreach (Object attributes in type.GetCustomAttributes(false))
            {
                DeBugInfo dbi = (DeBugInfo)attributes;
                if (null != dbi)
                {
                    Console.WriteLine("Bug no: {0}", dbi.BugNo);
                    Console.WriteLine("Developer: {0}", dbi.Developer);
                    Console.WriteLine("Last Reviewed: {0}", dbi.LastReview);
                    Console.WriteLine("Remarks: {0}", dbi.Message);
                }
            }
    //iterating through the method attribtues
            foreach (MethodInfo m in type.GetMethods())
            {
                foreach (Attribute a in m.GetCustomAttributes(true))
                {
                    DeBugInfo dbi = (DeBugInfo)a;
                    if (null != dbi)
                    {
                        Console.WriteLine("Bug no: {0}, for Method: {1}", dbi.BugNo, m.Name);
                        Console.WriteLine("Developer: {0}", dbi.Developer);
                        Console.WriteLine("Last Reviewed: {0}", dbi.LastReview);
                        Console.WriteLine("Remarks: {0}", dbi.Message);
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
