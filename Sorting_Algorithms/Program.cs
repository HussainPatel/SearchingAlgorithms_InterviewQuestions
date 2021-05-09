using System;

namespace Sorting_Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            #region "Selection Sort"
            int[] arr = new int[] { 4, 6, 5, 3, 9, 2, 1, 7, 8, 0 };
            Display(arr);
            Selection_Sort.SelectionSort(arr);
            Console.WriteLine();
            Display(arr);
            #endregion

            #region "Insertion Sort"
            //int[] arr = new int[] { 3, 5, 8, 6, 9, 2 };
            //Display(arr);
            //Insertion_Sort.Sort(arr);
            //Console.WriteLine();
            //Display(arr);
            #endregion

            #region "Bubble Sort"

            //int[] arr = new int[] { 3, 5, 8, 6, 9, 2 };

            //Display(arr);
            //Bubble_sort.BubbleSort(arr);
            //Console.WriteLine();
            //Display(arr);
            #endregion


            Console.Read();
        }

        public static void Display(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write("{0} ",item);
            }
        }        
    }
}
