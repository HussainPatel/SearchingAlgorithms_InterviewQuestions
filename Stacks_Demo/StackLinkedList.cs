using System;
using System.Collections.Generic;
using System.Text;

namespace Stacks_Demo
{
    public class StackLinkedList
    {
        private Node Top { get; set; }
        

        public int Size { get; set; }

        public void Push(int e)
        {
            var node = new Node(e);

            if (IsEmpty())
                Top = node;
            else
            {
                node.Next = Top;
                Top = node;
            }
            Size = Size + 1;
        }

        public int Length() => Size;

        public int Pop()
        {
            int element = 0;

            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }
            var current = Top;
            element = current.Value;
            Top = current.Next;
            Size = Size - 1;
            return element;

        }

        public int Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("stack is Empty");
            }
            return Top.Value;
        }


        public bool IsEmpty() => Size == 0;

        public void Display()
        {
            if (IsEmpty())
                Console.WriteLine("Stack is empty");
            else
            {
                var current = Top;

                while (current != null)
                {
                    Console.Write(current.Value + "=>");
                    current = current.Next;
                }
                Console.WriteLine("");
            }
        }
        public class Node {
            public int Value { get; set; }
            public Node Next { get; set; }

            public Node(int value)
            {
                this.Value = value;
                this.Next = null;
            }

            public override string ToString()
            {
                return "Node: " + Value;
            }
        }

        
    }
}
