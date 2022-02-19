using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

class MainClass
{
    public static void ShowInterfaces(Type t)
    {
        Type[] interfaces = t.GetInterfaces();
        Console.WriteLine("Implemented Interfaces");
        foreach (Type type in interfaces)
        {
            Console.WriteLine("Interface : {0}", type.FullName);
            if (type.IsPublic)                Console.WriteLine("Scope: Public");
            else                              Console.WriteLine("Scope: Private");
        }
    }
    
    public static void ShowTypes(string name, Assembly assembly)
    {
        Type[] typeArray = assembly.GetTypes();

        Console.WriteLine("Assembly Name: {0}", name);
        foreach (Type type in typeArray)
        {      if (type.IsClass)            {                ShowInterfaces(type);            }        }
    }
    public static void Main(string[] args)
    {
        for (int i = 0; i < args.Length; ++i)
        {
            // Get the assemble object (from System.Reflection)
            Assembly assembly = Assembly.LoadFrom(args[0]);            ShowTypes(args[0], assembly);
        }
    }
}