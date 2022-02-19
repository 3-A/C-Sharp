using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

public class MainClass
{
    public static void Main()
    {

        Stream s = new FileStream("d:\\test.txt", FileMode.Open);
        using (StreamReader sr = new StreamReader(s, Encoding.UTF8))
        {
            Console.WriteLine(sr.ReadToEnd());
        }
    }
}