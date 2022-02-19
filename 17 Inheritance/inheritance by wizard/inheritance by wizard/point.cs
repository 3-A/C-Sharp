using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace inheritance_by_wizard
{
    public class point
    {
        private int x; private int y;

        public int X        {     get { return x; }    set { x = value; }     }
        public int Y        {     get { return y; }    set { y = value; }     }
        public new int area() { return 10; }
    }
}
