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
namespace Using_the_foreach_Loop
{
    class MyArray
   {
      static void Main(string[] args) 
        {
            int leng; Console.WriteLine("Enter Length: "); leng = Convert.ToInt32(Console.ReadLine());
         int []  n = new int[leng]; /* n is an array of 10 integers */

         
         /* initialize elements of array n */         
         for ( int i = 0; i < leng; i++ )
         {
            n[i] = i + 100;
         }

         /* output each array element's value */
         foreach (int j in n )
         {
            int i = j-100;
            Console.WriteLine("Element[{0}] = {1}", i, j);
         //   i++;
         }
         Console.ReadKey();
      }
   }
}