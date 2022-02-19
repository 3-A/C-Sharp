using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class FileExample
{
    public static void Main()
    {
        string OriginalFile = "d://test.xml";
        string FileToReplace = "d://test2.xml";
        ReplaceFile(OriginalFile, FileToReplace, "d://test3.xml");
    }
    public static void ReplaceFile(string FileToMoveAndDelete, string FileToReplace, string BackupOfFileToReplace)
    {
        File.Replace(FileToMoveAndDelete, FileToReplace, BackupOfFileToReplace, false);

    }
}
