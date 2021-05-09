using System;
using System.Collections;

namespace HashTables_Demos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            #region
            //string str1 = "Listen";
            //string str2 = "Silent";
            //var result = TwoStringsAnagram.Anagram(str1: str1, str2: str2);
            //if (result)
            //    Console.WriteLine("the strings are anagram of each other");
            //else
            //    Console.WriteLine("the strings are not anagram of each other");
            #endregion

            //EmployeeHashTable.EmployeeHash();
            //FirstNonRepeatingCharacter.FirstNonRepeatingChar("GeeksForGeeks");

            #region "Remove Duplicate"
            int[] arr = new int[] { 1, 2, 3, 3, 3, 1, 4, 5 };
            ToRemoveDuplicateNumbers.RemoveDuplicate(arr);
            #endregion

            Console.ReadKey();
        }
    }
}
