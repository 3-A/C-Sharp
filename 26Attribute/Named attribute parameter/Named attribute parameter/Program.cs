using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

[AttributeUsage(AttributeTargets.All)]
public class MyAttribute : Attribute
{
    public string remark;
    public string supplement;
    public MyAttribute(string comment)    {        remark = comment;        supplement = "None";    }
    public string Remark                  {        get        {            return remark;        }  }
}

[MyAttribute("This class uses an attribute.",supplement = "This is additional info.")]
class UseAttrib                  {          }
class MainClass
{
    public static void Main()
    {   Type t = typeof(UseAttrib);
        Console.Write("Attributes in " + t.Name + ": ");
        object[] attribs = t.GetCustomAttributes(false);
        foreach (object o in attribs)        {            Console.WriteLine(o);        }
        Type tRemAtt = typeof(MyAttribute);       // Retrieve the MyAttribute. 
        MyAttribute ra = (MyAttribute) Attribute.GetCustomAttribute(t, tRemAtt);
        Console.Write("Remark: ");
        Console.WriteLine(ra.remark);
        Console.Write("Supplement: ");
        Console.WriteLine(ra.supplement);
    }
}
