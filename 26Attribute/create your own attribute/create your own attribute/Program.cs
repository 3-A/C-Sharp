using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
//[AttributeUsage(AttributeTargets.Class |
//                AttributeTargets.Constructor |
//                AttributeTargets.Field |
//                AttributeTargets.Method |
//                AttributeTargets.Property,
//                AllowMultiple = true)]
//public class BugFixAttribute : System.Attribute
//{
//    public int BugID;
//    public string Date;
//    public string Programmer;
//    public string Comment;

//    public BugFixAttribute(int bugID, string programmer, string date)
//    {
//        this.BugID = bugID;
//        this.Programmer = programmer;
//        this.Date = date;
//    }
//}
//[BugFixAttribute(1, "B", "01/04/05", Comment = "value")]
//public class MyMath
//{
//    public double DoFunc1(double param1)    {        return param1 + DoFunc2(param1);    }
//    public double DoFunc2(double param1)    {        return param1 / 3;    }
//    public void Main() { }
//}
//__________________________________________________________________
//public class CommandLineSwitchAliasAttribute : Attribute
//{
//    public CommandLineSwitchAliasAttribute(string alias)    {        Alias = alias;    }
//    public string Alias                                     {   get { return _Alias; }
//                                                                set { _Alias = value; }
//                                                            }
//    private string _Alias;
//}
//class CommandLineInfo
//{
//    [CommandLineSwitchAliasAttribute("?")]
//    public bool Help                         {       get { return _Help; }
//                                                     set { _Help = value; }
//                                             }
//    private bool _Help;
//}
//class MainClass
//{
//    static void Main()   
//  {
//      PropertyInfo property = typeof(CommandLineInfo).GetProperty("Help");
//      CommandLineSwitchAliasAttribute attribute = 
//      (CommandLineSwitchAliasAttribute)property.GetCustomAttributes(typeof(CommandLineSwitchAliasAttribute), false)[0];
//      if (attribute.Alias == "?")      {          Console.WriteLine("Help(?)");      };
//  }
//}
//______________________________________________________________________
public class TrueFalseAttribute : Attribute
{    bool bWritten;
    public bool Written()                      {        return bWritten;       }
    public TrueFalseAttribute(bool Written)    {        bWritten = Written;    }
}
[TrueFalseAttribute(true)]
public class Class1                            {                               }

[TrueFalseAttribute(false)]
public class Class2                            {              }
class MainClass
{
    public static void Main()
    {
        TrueFalseAttribute u;
        Console.Write("Class1 TrueFalseAttribute attribute: ");
        u = (TrueFalseAttribute)Attribute.GetCustomAttribute(typeof(Class1), typeof(TrueFalseAttribute));
        Console.WriteLine(u.Written());
        Console.Write("Class2 TrueFalseAttribute attribute: ");
        u = (TrueFalseAttribute)Attribute.GetCustomAttribute(typeof(Class2), typeof(TrueFalseAttribute));
        Console.WriteLine(u.Written());
    }
}