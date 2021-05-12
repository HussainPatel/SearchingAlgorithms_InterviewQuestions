using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Stacks_Demo
{
    public class BalancedExpressionsUsingStack
    {
        public  ArrayList leftBrackets = new ArrayList() { '(', '<', '[', '{' };
        public ArrayList rightBrackets = new ArrayList() { ')', '>', ']', '}' };

        public bool BalancedExpressions(string str)
        {
            char[] ch = str.ToCharArray();

            Stack<char> myStack = new Stack<char>();

            for (int i = 0; i < ch.Length; i++)
            {
                if (IsLeftBrackets(ch[i]))
                    myStack.Push(ch[i]);

                if (IsRightBrackets(ch[i]))
                {
                    if (myStack.Count == 0) return false;

                    var top = myStack.Pop();
                    if (!BracketsMatch(ch[i], top)) return false;
                }
            }

            return (myStack.Count == 0);
        }

        private bool IsLeftBrackets(char ch)
        {
            return leftBrackets.Contains(ch);
        }
        private bool IsRightBrackets(char ch)
        {
            return rightBrackets.Contains(ch);
        }

        private bool BracketsMatch(char ch, char top)
        {
            return (rightBrackets.IndexOf(ch) == leftBrackets.IndexOf(top));
        }



        /// <summary>
        /// Leet Code
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool IsValid(string s)
        {

            Stack<char> myStack = new Stack<char>();

            char[] ch = s.ToCharArray();

            for (int i = 0; i < ch.Length; i++)
            {
                if (leftBrackets.Contains(ch[i]))
                {
                    myStack.Push(ch[i]);
                }

                if (rightBrackets.Contains(ch[i]))
                {
                    if (myStack.Count == 0) return false;

                    var tmp = myStack.Pop();
                    if (leftBrackets.IndexOf(tmp) != rightBrackets.IndexOf(ch[i])) return false;
                }
            }

            return (myStack.Count == 0);
        }
    }
}
