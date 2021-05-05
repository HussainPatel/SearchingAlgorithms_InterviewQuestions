using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting_Algorithms
{
    public static class Selection_Sort
    {
        public static void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        var tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }
                }
            }

        }
    }
}
