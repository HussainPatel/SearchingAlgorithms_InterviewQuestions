using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Stacks_Demo
{
    public static class ReverseStringUsingStack
    {
        public static void ReverseString(string str)
        {
            char[] ch = str.ToCharArray();

            Stack<char> myStack = new Stack<char>();

            Console.WriteLine("push each character in stack");
            for (int i = 0; i < ch.Length; i++)
            {                
                myStack.Push(ch[i]);
            }

            Console.WriteLine("retrive the chara from stack");
            for (int i = 0; i < ch.Length; i++)
            {
                ch[i] = myStack.Pop();
            }

            Console.WriteLine(string.Join("",ch));
        }
    }
}
