using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting_Algorithms
{
    public static class Insertion_Sort
    {
        public static void Sort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                var tmp = arr[i];


                for (int j = i; j > 0 && arr[j - 1] > tmp; j--)
                {
                    arr[j] = arr[j - 1];
                    arr[j - 1] = tmp;
                }

            }
        }

    }
}
