﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleApplication
{
    class Rectangle
    {
        //member variables
        protected double length;
        protected double width;
        public Rectangle(double l, double w)        {            length = l;            width = w;        }
        public double GetArea()                     {            return length * width;                   }
        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }//end class Rectangle  
    class Tabletop : Rectangle
    {
        private double cost;
        public Tabletop(double l, double w)  : base(l, w)        { }
        public double GetCost()        {     double cost;  cost = GetArea() * 0.8;    return cost;          }
        public void Displayy()         {     base.Display();  Console.WriteLine("Cost: {0}", GetCost());   }
    }
    class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            Tabletop t = new Tabletop(1.9015, 1.324);
            t.Displayy();
            Console.ReadLine();
        }
    }
}
