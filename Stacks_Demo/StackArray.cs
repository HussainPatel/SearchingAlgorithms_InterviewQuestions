using System;
using System.Collections.Generic;
using System.Text;

namespace Stacks_Demo
{
    public class StackArray
    {
        int[] data;
        int top;

        public StackArray(int n)
        {
            this.data = new int[n];
            top = 0;
        }

        public int Length() => top;

        public bool IsEmpty() => top == 0;

        public bool IsFull() => top == data.Length;
        
        public void Push(int e)
        {
            if (IsFull())
            {
                Console.WriteLine("Stack is full / overflow");
            }
            else
            {
                data[top] = e;
                top = top + 1;
            }
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("stack is Empty/ Underflow");
                return -1;
            }

            int e = data[top - 1];
            top = top - 1;

            return e;
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is Empty / Under flow");
                return -1;
            }

            return data[top - 1];
        }

        public void Display()
        {
            for (int i = 0; i < top; i++)
                Console.Write(data[i] + "---");

            Console.WriteLine();
        }
    }
}
