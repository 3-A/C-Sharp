using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleclass
{
    partial class Test
    {
        partial void DoSomething();
        // we make method to call ((methodDoSomhing()))
        public void Do() { DoSomething(); }
    }
    class Program
    {
        static void Main(string[] args)
        {
            House myHouse = new House();
            House AAAHouse = new House(8,9);
            House KKAHouse = new House(4, 8);
            myHouse.DoorsNumber = 5;
            myHouse.OpenDoor();
            House.Floors floor = House.Floors.Third;//here enum we can access as example (enum consieder static)
            House.WindowsNumbers = 8;  //here filed static
            myHouse.FloorRank = floor;

            Test newtest = new Test();
            newtest.Do();
        }
    }
}
