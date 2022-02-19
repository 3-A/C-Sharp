using System;
using System.IO;
namespace FileIOApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream F = new FileStream("d:\\test.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            for (int i = 1; i <= 99; i++)            {      F.WriteByte((byte)i);              }

            F.Position = 0;
            for (int i = 0; i <= 99; i++)            {      Console.Write(F.ReadByte() + " "); }
            F.Close();
            Console.ReadKey();
        }
    }
}