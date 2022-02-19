using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* how defiend array in c#
 * int [] x = new int [5]................1
 * int [] x = new int [5] {1,2,3,4,5}....2
 * int [] x = {1,2,3,4,5}................3
 */ 
namespace array_with_rand_elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[5 ]; /* n is an array of 10 integers */
            int i, j;
            Random rndNumbers = new Random();        int rndNumber = 0;

            /* initialize elements of array n */
            for (i = 0; i < 5 ; i++)
            {
                //rndNumber = rndNumbers.Next();
                 rndNumber = rndNumbers.Next(20);
                n[i] = rndNumber;
            }

            /* output each array element's value */
            int sum=0 ;
            for (j = 0; j < 5; j++) { Console.WriteLine("Element[{0}] = {1}", j, n[j]); sum = sum + n[j]; }
            
            Console.WriteLine("Sum of array :{0}", sum);

            Console.ReadKey();
        }
    }
}
