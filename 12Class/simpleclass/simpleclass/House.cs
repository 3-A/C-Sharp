using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleclass
{
    class House
    {  
       public House() { }
       public House(int doors,int windows) { DoorsNumber = doors;WindowsNumbers = windows; }
       public int DoorsNumber;
       public Floors FloorRank;
       public static int WindowsNumbers;
       public void OpenDoor() { Console.WriteLine("Door Open"); }
       public enum Floors    { First, second, Third   }
    }
}
