using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

public class t
{
    public t() { }
    static t() { }
    public t(int i) { }

    public static void Main()
    {
        ConstructorInfo[] p = typeof(t).GetConstructors();        Console.WriteLine(p.Length);

        for (int i = 0; i < p.Length; i++)                  {     Console.WriteLine(p[i].IsStatic);        }
        p = typeof(t).GetConstructors( BindingFlags.Public | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Instance);
        Console.WriteLine(p.Length);

        for (int i = 0; i < p.Length; i++)          {          Console.WriteLine(p[i].IsStatic);        }
        Console.ReadKey();
    }
}