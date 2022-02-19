using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_Properties
{
    class Student
    {
        private string code = "N.A";
        private string name = "not known";
        private int age = 0;

        // Declare a Code property of type string:
        public string Code        {            get            {                return code;            }
                                               set            {                code = value;           }
                                  }
        // Declare a Name property of type string:
        public string Name        {            get            {                return name;            }
                                               set            {                name = value;           }
                                  }

        // Declare a Age property of type int:
        public int Age            {            get            {                return age;            }
                                               set            {                age = value;           }
                                  }
        public override string ToString()    { return "Code = " + Code + ", Name = " + Name + ", Age = " + Age;        }
    }
    class ExampleDemo
    {
        public static void Main()
        {
            Student s = new Student();               // Create a new Student object:
            s.Code = "001";                          // Setting code, name and the age of the student
            s.Name = "Zara";
            s.Age = 9;                     Console.WriteLine("Student Info: {0}", s);
         //let us increase age
            s.Age += 1; s.Code = "007";    Console.WriteLine("Student Info: {0}", s);
            Console.ReadKey();
        }
    }
}