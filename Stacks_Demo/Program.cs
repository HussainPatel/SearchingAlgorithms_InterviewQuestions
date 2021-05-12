using System;

namespace Stacks_Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            #region "Stack Array implementation"

            //StackArray stackArr = new StackArray(10);

            //stackArr.Push(5);
            //stackArr.Push(3);
            //stackArr.Display();
            //Console.WriteLine(stackArr.Length());
            //Console.WriteLine("Element Popped {0}", stackArr.Pop());
            //Console.WriteLine("Is Empty {0}", stackArr.IsEmpty());
            //Console.WriteLine("Element Popped {0}", stackArr.Pop());
            //Console.WriteLine("Is Empty {0}", stackArr.IsEmpty());
            //stackArr.Push(7);
            //stackArr.Push(9);
            //Console.WriteLine(stackArr.Length());
            //Console.WriteLine("Element Top {0}", stackArr.Peek());
            //stackArr.Display();           

            #endregion


            #region "Stack as Linked List"

            StackLinkedList s = new StackLinkedList();
            s.Push(10);
            s.Push(5);
            s.Display();
            Console.WriteLine(s.Size);
            Console.WriteLine("Popup Element {0}", s.Pop());
            s.Display();
            Console.WriteLine(s.Size);
            Console.WriteLine(s.Peek());

            #endregion


            // Console.Write("The expression are matched : ");
            //string str = "Hello World!";
            //ReverseStringUsingStack.ReverseString(str);
            //ReverseStringRecursive.ReverseString(str);

            #region "Balance Expression"

            //string strExpression = "()";
            //BalancedExpressionsUsingStack exp = new BalancedExpressionsUsingStack();
            //Console.WriteLine(exp.BalancedExpressions(strExpression));

            //// leet Code
            //Console.WriteLine(exp.IsValid(strExpression));
            #endregion

            Console.ReadKey();
        }
    }
}
