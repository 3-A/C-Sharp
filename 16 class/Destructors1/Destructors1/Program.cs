﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destructors1
{
    class Line
    {
        private double length;   // Length of a line
        // constructor
        public Line()          {      Console.WriteLine("Object is being created");        }
        //destructor
        ~Line()                {      Console.WriteLine("Object is being deleted");        }

        public void setLength(double len)       {            length = len;         }
        public double getLength()               {            return length;        }

        static void Main(string[] args)
        {
            Line line = new Line();
            // set line length
            line.setLength(6.0); Console.WriteLine("Length of line : {0}", line.getLength()); 
            Console.ReadKey();
        }
    }
}
