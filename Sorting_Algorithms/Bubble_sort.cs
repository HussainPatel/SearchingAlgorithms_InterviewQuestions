using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting_Algorithms
{
   public static class Bubble_sort
    {
        public static void BubbleSort(int[] arr)
        {

            //        //if the element on left is grater than element on right
            //        //we swap the elements
            //        // comparision of consicutive elements has to be done

            for (int pass = arr.Length - 1; pass >= 0; pass--)
            {
                for (int i = 0; i < pass; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        var tmp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = tmp;
                    }
                }
            }

        }
    }
}
