using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class MainClass
{
    static void Main(string[] args)
    {
        StreamWriter MyStream = null;
        string MyString = "Hello World";

        try
        {
            //MyStream = File.CreateText("MyFile.txt");
            MyStream = File.CreateText("d://aaa.txt");
            MyStream.Write(MyString);
        }
        catch (IOException e)
        {
            Console.WriteLine(e);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        finally
        {
            if (MyStream != null)
                MyStream.Close();
        }
    }
}