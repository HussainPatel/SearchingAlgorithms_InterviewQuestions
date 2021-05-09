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

                // compaare i with all number will end 
                // if the number is less than i
                // them swap 
                // follow this till end of j iteration
                // repeat this for i til lthe end.
                for (int j = i+1; j < arr.Length; j++)
                {
                    //if right is less than left we swap
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
