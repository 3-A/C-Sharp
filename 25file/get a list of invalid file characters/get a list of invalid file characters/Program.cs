using System;
using System.IO;
class GetCharExample
{
    public static void Main()
    {
        char[] invalidFileChars = Path.GetInvalidFileNameChars();

        Console.WriteLine("The following characters are invalid in a filename:");
        ShowChars(invalidFileChars);
    }
    public static void ShowChars(char[] charArray)
    {
      foreach (char someChar in charArray)    {  Console.WriteLine("{0:c},\t{1:X4}", someChar, (int)someChar);    }
    }
}
