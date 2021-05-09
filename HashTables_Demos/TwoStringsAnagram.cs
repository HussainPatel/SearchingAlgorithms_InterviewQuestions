using System;
using System.Collections.Generic;
using System.Text;

namespace HashTables_Demos
{
    public static class TwoStringsAnagram
    {

        /// <summary>
        /// An anagram of a string is another string that contains the same characters, 
        /// only the order of characters can be different. 
        /// For example, “abcd” and “dabc” are an anagram of each other.
        /// </summary>
        public static bool Anagram(string str1, string str2)
        {
            char[] ch1 = str1.ToLower().ToCharArray();

            char[] ch2 = str2.ToLower().ToCharArray();

            if (ch2.Length != ch2.Length)
                return false;

            Array.Sort(ch1);
            Array.Sort(ch2);

            Console.WriteLine(ch1.ToString());
            Console.WriteLine(ch2.ToString());

            for (int i = 0; i < ch1.Length; i++)
            {
                if (ch1[i] != ch2[i])
                    return false;
            }

            return true;
        }

    }
}
