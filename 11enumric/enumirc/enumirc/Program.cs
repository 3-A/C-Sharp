using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumirc
{
    enum Cars    { BMW,Merceded,Toyota,Honda,Dodeg,Helman   } //write in only in class or namespace
    class Program
    {
        //method
        static void ChangeCar(Cars oldCar, Cars newCar)
        {
            if (oldCar == newCar) { Console.WriteLine("wrong chice"); return; }
            Console.WriteLine("You Wanted To Chage Your "+oldCar+" with a "+ newCar);
            switch (oldCar)
            {
                case Cars.BMW:      Console.WriteLine("You 'll gain 5000$ for chaning your " + oldCar); break;
                case Cars.Merceded: Console.WriteLine("You 'll gain 4000$ for chaning your " + oldCar); break;
                case Cars.Toyota:   Console.WriteLine("You 'll gain 3000$ for chaning your " + oldCar); break;
                case Cars.Honda:    Console.WriteLine("You 'll gain 1000$ for chaning your " + oldCar); break;
            }
            switch (newCar)
            {
                case Cars.BMW:      Console.WriteLine("You 'll pay 1000$ for chaning your " + newCar); break;
                case Cars.Merceded: Console.WriteLine("You 'll pay 7000$ for chaning your " + newCar); break;
                case Cars.Toyota:   Console.WriteLine("You 'll pay 4000$ for chaning your " + newCar); break;
                case Cars.Honda:    Console.WriteLine("You 'll pay 2000$ for chaning your " + newCar); break;
            }
        }
        static void Main(string[] args)
        { Console.BackgroundColor = ConsoleColor.DarkRed ;Console.WriteLine("GGGGGGG");
            ChangeCar(Cars.BMW, Cars.Helman);
            ChangeCar(Cars.BMW, Cars.Honda);
        }
    }
}
