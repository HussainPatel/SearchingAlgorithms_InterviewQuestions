using System;

namespace SearchingAlgorithmsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            #region "Iterative
            //int[] arr = new int[] { 4, 11, 18, 30, 54 };

            //var result = SearchElement_Iterative.SearchElementIterative(arr, 30);

            //if (result == -1)
            //    Console.WriteLine("the element was not found");
            //else
            //    Console.WriteLine("the element was found at position: {0}", result);
            #endregion

            #region "BS iterative"
            //int[] arr = new int[] { 4, 11, 18, 30, 54 };

            //var result = SearchElement_BS_Iterative.SearchElementBSIterative(arr, 54);

            //if (result == -1)
            //    Console.WriteLine("the element was not found");
            //else
            //    Console.WriteLine("the element was found at position: {0}", result);
            #endregion

            #region "Binary Search - Recursion"
            int[] arr = new int[] { 4, 11, 18, 30, 54 };

            var result = SearchElement_BS_Recursion.SearchElementBSRecursion(arr, 55);

            if (result == -1)
                Console.WriteLine("the element was not found");
            else
                Console.WriteLine("the element was found at position: {0}", result);
            #endregion
        }
    }
}
