using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passing_Arrays_as_Function_Arguments
{
    class aaa
    {
        double getAverage(int[] arr, int size)
        {
            int i;         double avg;            int sum = 0;
            for (i = 0; i < size; ++i)         {     sum += arr[i];       }
            avg = (double)sum / size;           return avg;
        }
        static void Main(string[] args)
        {
            aaa app = new aaa();

            /* an int array with 5 elements */
            int[] balance = new int[] {1,2,3,4,5};           double avg;

            /* pass pointer to the array as an argument */
            avg = app.getAverage(balance, 5);

            /* output the returned value */
            Console.WriteLine("Average value is: {0} ", avg);
            Console.ReadKey(); 

         
        }
    }
}
