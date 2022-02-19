using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpledelegates
{
    class Program
    {
        //delegate as bag contien method will runing if you call Delegate
        //all method in delegate must have one type return of retrun type//all void or all int or all string
        public delegate void Calc(int f, int s);
        public static void Sum(int firstNumber, int secondNumber) { Console.WriteLine("Result : {0}", firstNumber + secondNumber); }
        public static void Sub(int firstNumber, int secondNumber) { Console.WriteLine("Result : {0}", firstNumber - secondNumber); }
        public static void Mlt(int firstNumber, int secondNumber) { Console.WriteLine("Result : {0}", firstNumber * secondNumber); }
        public static void Div(int firstNumber, int secondNumber) { Console.WriteLine("Result : {0}", firstNumber / secondNumber); }

        static void Main(string[] args)
        {
             Sum(9, 1);
             Calc myDelegate = null; //or Calc myDelegate = new Calc();//defineds Delegate
            myDelegate += Sum;       //or myDelegate += new Calc(Sum);
            myDelegate += Sub;
            myDelegate += Mlt;
            myDelegate += Div;

            myDelegate(6, 2); //here all method will runing at onec tiem (as bag)

            myDelegate -= Mlt;
            myDelegate(6, 2); //-=Sub method willnot runing
            //Anonymous method
            myDelegate += new Calc(delegate (int num1, int num2) { Console.WriteLine(num1 * num2 * 10); });
            //or
            myDelegate +=  delegate (int num1, int num2) { Console.WriteLine(num1 * num2 * 10); } ;
            myDelegate(60, 20);
            //Lambda Expression >>>>>   X=>x*x    //mean given X caclute x*x

            myDelegate += new Calc( (x,y) => Console.WriteLine(x*y*10) );
            myDelegate(60, 20);



        }
    }
}

