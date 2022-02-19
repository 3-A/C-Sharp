using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleproperties
{
    class Rectangle
    {
        int _Hight;
        int _Width;
        string _Name;
        public int Hight             {//here properties work as method
                                       get    { if (_Hight.Equals(0)) { return (10); } return _Hight;   }
                                       set    { _Hight = value;     }
                                     }
        public int Width             {
                                       get    {  return _Width;     }
                                       set    { _Width = value;     }
                                     }

        public string Name
                          {
                            get   {   if (_Name.Contains("I")) { return "I it's found"; }
                                      return _Name;
                                  }
                            set   {           _Name = value;            }
                          }

        public int Area (int x, int y) { return x * y ; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle Rect = new Rectangle();
            Rect.Hight = int.Parse(Console.ReadLine());
            Rect.Width = int.Parse(Console.ReadLine());
            int result = Rect.Area(Rect.Hight, Rect.Width);
            Console.WriteLine(  result);
            Rect.Name = "kjj  PO";
            Console.WriteLine(Rect.Name );


        }
    }
}
