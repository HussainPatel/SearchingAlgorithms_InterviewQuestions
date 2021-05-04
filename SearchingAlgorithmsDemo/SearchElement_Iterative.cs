using System;
using System.Collections.Generic;
using System.Text;

namespace SearchingAlgorithmsDemo
{
    public static class SearchElement_Iterative
    {
        public static int SearchElementIterative(int[] arr, int elementToSearch)
        {
            if (arr.Length == 0 || arr == null)
                return -1;

            int i = 0;
            while (i < arr.Length)
            {
                if (arr[i] == elementToSearch)
                    return i;

                i++;
            }

            return -1;
        }
    }
}
