using System;
using System.Collections.Generic;
using System.Collections;


namespace facebookrecruiting_coding_practice_questions
{
    #region "Blanced Brackets"
    class BalancedBrackers
    {
        //static void Main(string[] args)
        //{
        //    // string myString = "{(})";
        //    string myString = "{[()]}";
        //    //Call isBalanced() with test cases here
        //    Console.WriteLine("is balanced :" + isBalanced(myString));
        //    Console.ReadKey();
        //}

        private static bool isBalanced(string s)
        {
            ArrayList leftBrackets = new ArrayList() { '(', '[', '<', '{' };
            ArrayList rightBrackets = new ArrayList() { ')', ']', '>', '}' };

            // Write your code here
            char[] ch = s.ToCharArray();

            Stack<char> myStack = new Stack<char>();

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
                    if (!(leftBrackets.IndexOf(tmp) == rightBrackets.IndexOf(ch[i])))
                        return false;
                }
            }

            return myStack.Count == 0;
        }
    }

    #endregion
    class ForeignCurrency
    {
        static void Main(string[] args)
        {
            // Call canGetExactChange() with test cases here
        }

        private static bool canGetExactChange(int targetMoney, int[] denominations)
        {
            // Write your code here[ g
             
            return false;
        }

    }
}
