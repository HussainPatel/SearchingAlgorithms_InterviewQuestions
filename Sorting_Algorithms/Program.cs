using System;

namespace Sorting_Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            int[] arr = new int[] { 4, 6, 5, 3, 9, 2, 1, 7, 8, 0 };

            Display(arr);
            Selection_Sort.SelectionSort(arr);

            Console.WriteLine();

            Display(arr);

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
