using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.Sort
{
    public static class InsertionSort
    {

        public static void InsertionSortArrayList<T>(this T[] arr) where T : IComparable<T>
        {
           
            for (int i = 1; i < arr.Length; i++)
            {
                int j = i;
                while (j > 0)
                {
                    if(arr[j].CompareTo(arr[j-1]) > 0)
                    {
                        T temp = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = temp;
                        j--;
                    }
                    else
                        break;
                }
                Console.Write("Iteration " + i.ToString() + ": ");
                for (int k = 0; k < arr.Length; k++)
                    Console.Write(arr[k] + " ");
                Console.Write("\n");
                //Console.Write("/*** " + (i + 1).ToString() + " numbers from the begining of the array are input and they are sorted ***/\n");  
            }

        }
    }
}
