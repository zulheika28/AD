using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.Sort
{
    public static class BubbleSort
    {
        public static void BubbleSortArrayList<T>(this T[] arr) where T : IComparable<T>
        {
            // Loop through outer loop
            for (var i = 0; i < arr.Length; i++)
            {
                // Loop through inner loop
                for (var j = 0; j < arr.Length - 1 ; j++)
                {
                    // swap two elements if the left element is greater than the right element.
                    if (arr[j].CompareTo(arr[j+1]) >0)
                    {
                        // Swap Elements
                        SwapClass.Swap<T>(ref arr[j], ref arr[j + 1]);
                    }
                }
            }
        }
    }
}
