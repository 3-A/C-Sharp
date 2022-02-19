using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleInterface
{  
    class Program
    {
        interface IAnaimal
        {
            void Eat();
            void Drink();
        }
       abstract class Anaimal : IAnaimal
        {
            public void Eat() { Console.WriteLine("Eat"); }
            public void Drink() { Console.WriteLine("Drink"); }
            public void Walk() { Console.WriteLine("Walk"); }
            public abstract void Voice();
            string _Name;
            public abstract string Name    {    get;       set;    }
        }
         class Cat : Anaimal
        {//here defiend any abstract from up method or properties
            public override void Voice()       {Console.WriteLine("Voice"); }
            string CatName;
            //here defiend any abstract from up properties
            public override string Name    {
                                             get { return CatName; }
                                             set { CatName = value; }
                                           }
        }

        static void Main(string[] args)
        {
            //Anaimal aaa = new Anaimal();//becaues abstrct we can not take object from it.
            //aaa.Eat();
            //aaa.Drink();
            //aaa.Walk();
            Cat mycat = new Cat();
            mycat.Voice();
            mycat.Name = "LLKKK:||\n\t\\\\\b ";
            Console.WriteLine(mycat.Name);
        }
    }
}
