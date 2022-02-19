using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
//[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
//public class CodeReviewAttribute : System.Attribute
//{
//    public CodeReviewAttribute(string reviewer, string date)    {        this.reviewer = reviewer;        this.date = date;    }
//    public string Comment              {        get    {        return (comment);        }
//                                                set    {        comment = value;         }
//                                       }
//    public string Date                 {        get    {        return (date);           }    }
//    public string Reviewer             {        get    {        return (reviewer);       }    }
//    string reviewer;
//    string date;
//    string comment;
//}
//[CodeReview("Name1", "01-12-2000", Comment = "comment1")]
//[CodeReview("Name2", "01-01-2012", Comment = "comment2")]
//class Complex               {                    }
//class MainClass             
//{
//    public static void Main()
//    {
//        Type type = typeof(Complex);
//        foreach (CodeReviewAttribute att in type.GetCustomAttributes(typeof(CodeReviewAttribute), false))
//        {
//            Console.WriteLine("Reviewer: {0}", att.Reviewer);
//            Console.WriteLine("Date: {0}", att.Date);
//            Console.WriteLine("Comment: {0}", att.Comment);
//        }
//    }
//}
//__________________________________________________________________________________
[AttributeUsage(AttributeTargets.Class)]
public class ClassTarget : Attribute         {    public ClassTarget()    {    }          }

[AttributeUsage(AttributeTargets.Method)]
public class MethodTarget : Attribute        {    public MethodTarget()   {    }          }
public class MyClass
{
    [MethodTarget]
    public int MyMethod()                   {        return 5;     }
}
class MainClass
{
    public static void Main(string[] args)
    {   ClassTarget rs;
        MethodTarget rm;
        Assembly a = Assembly.LoadFrom("MyClass");
        foreach (Type t in a.GetTypes())
        {  rs = (ClassTarget)Attribute.GetCustomAttribute(t, typeof(ClassTarget));
            if (rs != null)
            { foreach (MethodInfo m in t.GetMethods())
                 {    rm = (MethodTarget)Attribute.GetCustomAttribute(m, typeof(MethodTarget));
                                 if (rm != null)  {         Object o = Activator.CreateInstance(t);
                                                            Object[] aa = new Object[0];
                                                            int i = (int)m.Invoke(o, aa);
                                                  }
                 }
            }
        }
    }
}