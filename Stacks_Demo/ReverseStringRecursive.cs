using System;
using System.Collections.Generic;
using System.Text;

namespace Stacks_Demo
{
    public static class ReverseStringRecursive
    {
        public static void ReverseString(string str)
        {
            char[] ch = str.ToCharArray();
            ReverseStringHelper(ch, 0, ch.Length - 1);

            Console.WriteLine(string.Join("",ch));
        }

        private static void ReverseStringHelper(char[] s, int left, int right)
        {
            if (left > right) return;
            char tmp = s[left];
            s[left++] = s[right];
            s[right--] = tmp;

            ReverseStringHelper(s, left, right);
        }
    }
}
