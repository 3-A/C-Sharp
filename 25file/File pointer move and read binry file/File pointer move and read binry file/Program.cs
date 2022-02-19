using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
class Class1
{
    static void Main(string[] args)
    {
        byte[] byData = new byte[100];
        char[] charData = new Char[100];
                                                                                                                         
        FileStream aFile = new FileStream("d://practice.txt", FileMode.Open);
        aFile.Seek(55, SeekOrigin.Begin);
        aFile.Read(byData, 0, 100);
        Decoder d = Encoding.UTF8.GetDecoder();
        d.GetChars(byData, 0, byData.Length, charData, 0);
        Console.WriteLine(charData);
        return;
    }
}