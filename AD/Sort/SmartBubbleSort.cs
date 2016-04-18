using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.Sort
{
    public static class SmartBubbleSort
    {
        public static Boolean sorted;

        public static void SmartBubbleSortArrayList<T>(this T[] arr) where T : IComparable<T>
        {
            //this checks if the array is already sorted. if its not then it continues sorting
            if (!sorted)
            { 
            // Loop through outer loop
            for (var i = 0; i < arr.Length; i++)
            {
                // Loop through inner loop
                for (var j = 0; j < arr.Length - 1; j++)
                {
                    // swap two elements if the left element is greater than the right element.
                    if (arr[j].CompareTo(arr[j + 1]) > 0)
                    {
                        // Swap Elements
                        SwapClass.Swap<T>(ref arr[j], ref arr[j + 1]);
                    }
                }
            }
        }
        }

        public static void sortedCheck(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i - 1] > arr[i])
                {
                    sorted = false;
                }
            }
           sorted= true;
    }
    }
}
