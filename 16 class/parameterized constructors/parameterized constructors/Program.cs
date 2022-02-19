﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parameterized_constructors
{
    class Line
    {
        private double length;   // Length of a line
        //Parameterized constructor
        public Line(double len)            {    Console.WriteLine("Object is being created, length = {0}", len); length = len;      }
        public void setLength(double len)  {         length = len;        }
        public double getLength()          {            return length;    }
        static void Main(string[] args)
        {
            Line line = new Line(10.0);         Console.WriteLine("Length of line : {0}", line.getLength());
             // set line length
            line.setLength(6.0);                Console.WriteLine("Length of line : {0}", line.getLength());
            Console.ReadKey();
        }
    }
}
