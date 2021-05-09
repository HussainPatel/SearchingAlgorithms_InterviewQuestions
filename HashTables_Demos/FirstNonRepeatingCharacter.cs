using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace HashTables_Demos
{
    public static class FirstNonRepeatingCharacter
    {
        /// <summary>
        /// to solve the problem we need ot iterate over the string and count the number of times the character is repeated
        /// then again we iterate ove the hash tavbe and look yp how many times the character is repeated aif its is less than equal to 1 we stop.
        /// </summary>
        /// <param name="str"></param>
        public static void FirstNonRepeatingChar(string str)
        {
            Dictionary<char, int> charsCount = new Dictionary<char, int>();

            char[] chArr = str.ToLower().ToCharArray();

            for (int i = 0; i < chArr.Length; i++)
            {
                if (charsCount.ContainsKey(chArr[i]))
                {
                    var tmp = charsCount.GetValueOrDefault(chArr[i]);
                    charsCount.Remove(chArr[i]);
                    tmp++;
                    charsCount.Add(chArr[i], tmp);
                }
                else
                {
                    charsCount.Add(chArr[i], 1);
                }
            }

            Console.WriteLine("Total count after iteration");
            foreach (var item in charsCount)
            {
                Console.WriteLine("key {0} value {1}", item.Key, item.Value);
            }

            for (int i = 0; i <chArr.Length; i++)
            {
                var value = charsCount.GetValueOrDefault(chArr[i]);
                if (value == 1)
                {
                    Console.WriteLine("the first non repeating char is {0}", chArr[i]);
                    break;
                }
            }
            

        }
    }
}
