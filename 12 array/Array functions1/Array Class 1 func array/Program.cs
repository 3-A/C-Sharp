using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Class
{
    class Program
    {
        static void printarray(int[] arr)   {
                                              Console.WriteLine("\nElements of array is:\n");
                                              foreach (int i in arr)   { Console.Write("\t{0}", i);            }
                                              Console.WriteLine("\n");
                                            }
        static void Main(string[] args)
        {
            //Initializing and storing value in arr1
            int[] arr1 = new int[5] { 43, 25, 33, 14, 5 };
            int[] arr2 = new int[5];
            int len, rank;
            bool fixedsize, read_only;

            //Check array length
            len = arr1.Length;                     Console.WriteLine("Length:\t{0}", len);

            //Check array rank
            rank = arr1.Rank;                      Console.WriteLine("Rank:\t{0}", rank);

            //Check whether array is fixed size or not
            fixedsize = arr1.IsFixedSize;          Console.WriteLine("Fixed Size:\t{0}", fixedsize);

            //Check whether array is read only or not
            read_only = arr1.IsReadOnly;           Console.WriteLine("Read Only:\t{0}", read_only);

            //Sorting an array
            Array.Sort(arr1);                     printarray(arr1);

            //Returning Lenght from specified position
            Console.WriteLine("Get Length:\t{0}", arr1.GetLength(0));

            //Returns value of specied position
            Console.WriteLine("Get Value:\t{0}", arr1.GetValue(2));
                      
            //Returns Index position of specified value
            Console.WriteLine("Get Index:\t{0}", Array.IndexOf(arr1, 33));

            //Copying arr1's items to arr2
            Array.Copy(arr1, arr2, 5);            printarray(arr2);
            Console.WriteLine("MAX:\t{0}", arr1.Max());
            Console.WriteLine("MIN:\t{0}", arr1.Min());
            //Removing items from array.
            Array.Clear(arr1, 0, 5);              printarray(arr1);
            Console.ReadLine();
        }
    }
}
