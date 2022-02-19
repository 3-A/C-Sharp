using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
class MainClass
{
    [Conditional("TRIAL")]
    void trial()          {        Console.WriteLine("Trial version, not for distribution.");    }
     
    [Conditional("RELEASE")]
    void release()        {        Console.WriteLine("Final release version.");                  }

    public static void Main()
    {   MainClass t = new MainClass();
        t.trial(); // call only if TRIAL is defined 
        t.release(); // called only if RELEASE is defined 
    }
}
// public class MyClass {

//  [Conditional("DEBUG")]
//  public void OnlyWhenDebugIsDefined( ) {    Console.WriteLine("DEBUG is defined");  }
//                       }
//public class MainClass {
//  public static void Main( ) {    MyClass f = new MyClass( );    f.OnlyWhenDebugIsDefined( );  }
//                       } 