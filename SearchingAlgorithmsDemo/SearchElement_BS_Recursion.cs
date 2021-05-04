using System;
using System.Collections.Generic;
using System.Text;

namespace SearchingAlgorithmsDemo
{
    public static class SearchElement_BS_Recursion
    {
        public static int SearchElementBSRecursion(int[] arr, int element)
        {
            return HelperRecusrion(arr, element, 0, arr.Length - 1);
        }

        private static int HelperRecusrion(int[] arr, int element,  int left, int right)
        {
            if (left > right)
                return -1;
            else
            {
                var mid = (left + right) / 2;

                if (element == arr[mid])
                    return mid;

                if (element < arr[mid])
                    return HelperRecusrion(arr, element, left, mid - 1);
                else if (element > arr[mid])
                    return HelperRecusrion(arr, element, mid + 1, right);
            }

            return -1;
        }
    }
}
