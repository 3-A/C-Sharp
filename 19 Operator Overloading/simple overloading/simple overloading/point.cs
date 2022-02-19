using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_overloading
{
    class point
    {   //fields
        int x;   int y;
        public int X        {            get { return x; }            set { x = value; }        } 
        public int Y        {            get { return y; }            set { y = value; }        }
         // constrcutor
        public point() { x = 0; y = 0; }
        public point(int xpos) { x = xpos; y = xpos; }
        public point(int xpos, int ypos) { x = xpos; y = ypos; }


        //method
        public static point add(point p1, point p2)
        {
            point p = new point();
            p.X = p1.x + p2.x;
            p.Y = p1.y + p2.y;
            return p;
        }
        // operator overload
        public static point operator + (point p1, point p2)
        {
            point p = new point();
            p.X = p1.x + p2.x;
            p.Y = p1.y + p2.y;
            return p;
        }
        public static point operator /(point p1, point p2)
        {
            point p = new point();
            p.X = p1.x / p2.x;
            p.Y = p1.y / p2.y;
            return p;
        }
        public static bool operator > (point p1, point p2)
        {
            if   (p1.x > p2.x && p1.y > p2.y) { return true; }
            else                              {return false;}
        }
        public static bool operator <(point p1, point p2)
        {
            if (p1.x < p2.x && p1.y < p2.y) { return true; }
            else { return false; }
        }
        public static point operator ++(point p1)
        {
            p1.X ++;
            p1.Y ++;
            return p1;
        }
    }
}
