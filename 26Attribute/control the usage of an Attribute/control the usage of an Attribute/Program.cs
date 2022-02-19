using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
[AttributeUsage(AttributeTargets.All)]
public class MyAttribute : Attribute
{
    string remark;

    public MyAttribute(string comment)    {        remark = comment;    }
    public string Remark                  {        get {   return remark;        }    }
    public void Main() { }
}