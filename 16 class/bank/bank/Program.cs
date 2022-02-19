using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    class bank
    {    //fields
        int account_no;
        string name;
        //property
        public string Name        {
                                       get { return name; }
                                       set { name = value; }
                                  }
        public int Account_no     {
                                       get { return account_no; }
                                       set { account_no = value; }
                                  }
        
        //constructor
        public bank()               { account_no = 50; }
        //overload constructor
        public bank(int x)          { account_no = x; }
        //methods
        public void deposite()      { account_no = ((account_no * 10) / 100) + account_no; }
    }
    class Program
    {
        static void Main(string[] args)
        {
         bank aaa = new bank();   Console.WriteLine("aaa.Account_no := {0}", aaa.Account_no);
              aaa.Name = "omar";   Console.WriteLine("aaa.Name := {0}", aaa.Name);
              Console.WriteLine("aaa.Account_no := {0}", aaa.Account_no);
         bank ccc = new bank(6000); Console.WriteLine("ccc.Account_no := {0}", ccc.Account_no);
         ccc.deposite(); Console.WriteLine("After deposite ccc.Account_no := {0}", ccc.Account_no);
            Console.ReadKey(false);
        }
    }
}
