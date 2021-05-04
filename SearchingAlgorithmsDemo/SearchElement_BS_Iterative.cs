using System;
using System.Collections.Generic;
using System.Text;

namespace SearchingAlgorithmsDemo
{
    public static class SearchElement_BS_Iterative
    {

        public static int SearchElementBSIterative(int[] arr, int element)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                var mid = (left + right) / 2;

                if (element == arr[mid])
                    return mid;

                if (element < arr[mid])
                {
                    right = mid - 1;
                }
                else if(element > arr[mid])
                    left = mid + 1;
            }

            return -1;
        }
    }
}
