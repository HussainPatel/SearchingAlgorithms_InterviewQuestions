using System;

namespace Queues_Demo
{
    #region "Queue Array"
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Hello World!");
    //        QueuesArray q = new QueuesArray(10);
    //        q.Enqueue(5);
    //        q.Enqueue(3);
    //        q.Display();
    //        Console.WriteLine("Size " + q.Length());
    //        Console.WriteLine("Elements Removed : " + q.Dequeue());
    //        Console.WriteLine("Is Empty : " + q.IsEmpty());
    //        Console.WriteLine("Elements Removed : " + q.Dequeue());
    //        Console.WriteLine("Is Empty : " + q.IsEmpty());
    //        q.Enqueue(7);
    //        q.Enqueue(9);
    //        q.Enqueue(4);
    //        q.Display();
    //        Console.WriteLine("Size " + q.Length());

    //        Console.ReadKey();
    //    }
    //}

    public class QueuesArray
    {
        int[] data;
        int front;
        int rear;
        int size;

        public QueuesArray(int n)
        {
            data = new int[n];
            front = 0;
            rear = 0;
            size = 0;
        }

        public int Length() => size;

        public bool IsEmpty() => size == 0;

        public bool IsFull() => size == data.Length;

        public void Enqueue(int e)
        {
            if (IsFull())
            {
                Console.WriteLine("Queue is Full");
                return;
            }
            else
            {
                data[rear] = e;
                rear = rear + 1;
                size = size + 1;
            }
        }

        public int Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is Empty");
                return -1;
            }
            else
            {
                var e = data[front];
                front = front + 1;
                size = size - 1;
                return e;
            }
        }

        public void Display()
        {
            for (int i = front; i < rear; i++)
            {
                Console.Write(data[i] + " ");
            }

            Console.WriteLine();
        }
    }

    #endregion


    #region ""Queue Linked List"
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Hello World!");
    //        QueueLink q = new QueueLink();
    //        q.Enqueue(5);
    //        q.Enqueue(3);
    //        q.Display();
    //        Console.WriteLine("Size " + q.Length());
    //        Console.WriteLine("Elements Removed : " + q.Dequeue());
    //        Console.WriteLine("Is Empty : " + q.IsEmpty());
    //        Console.WriteLine("Elements Removed : " + q.Dequeue());
    //        Console.WriteLine("Is Empty : " + q.IsEmpty());
    //        q.Enqueue(7);
    //        q.Enqueue(9);
    //        q.Enqueue(4);
    //        q.Display();
    //        Console.WriteLine("Size " + q.Length());

    //        Console.ReadKey();         
    //    }
    //}

    class QueueLink
    {
        public Node Front;
        public Node Rear;
        public int Size;

        public QueueLink()
        {
            Front = null;
            Rear = null;
            Size = 0;
        }


        public int Length() => Size;

        public bool IsEmpty() => Size == 0;

        public void Enqueue(int n)
        {
            var node = new Node(n);

            if (IsEmpty())
            {
                Front = node;
            }
            else
            {               
                Rear.Next = node;
            }

            Rear = node;
            Size = Size + 1;
        }

        public int Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty");
                return -1;
            }

            var e = Front.element;
            Front = Front.Next;
            Size = Size - 1;
            if (IsEmpty())
                Rear = null;

            return e;
        }

        public void Display()
        {
            Node p = Front;
            while (p != null)
            {
                Console.Write(p.element + "--");
                p = p.Next;
            }
            Console.WriteLine();
        }
        public class Node
        {
            public int element;
            public Node Next;

            public Node(int n)
            {
                element = n;
                Next = null;
            }
        }
    }
    #endregion

    #region "DE Que"

    class DEQueLink
    {
        public Node Front;
        public Node Rear;
        public int Size;

        public DEQueLink()
        {
            Front = null;
            Rear = null;
            Size = 0;
        }


        public int Length() => Size;

        public bool IsEmpty() => Size == 0;
        public void Display()
        {
            Node p = Front;
            while (p != null)
            {
                Console.Write(p.element + "--");
                p = p.Next;
            }
            Console.WriteLine();
        }

        public void AddLast(int e)
        {
            var node = new Node(e);

            if (IsEmpty())
            {
                Front = node;
            }
            else
            {
                Rear.Next = node;
            }

            Rear = node;
            Size = Size + 1;
        }

        public void AddFirst(int e)
        {
            var node = new Node(e);
            if (IsEmpty())
            {
                Front = node;
            }
            else
            {              
                node.Next = Front;
                Front = node;
            }

            Size = Size + 1;
        }


        public int RemoveFront()
        {
            if (IsEmpty())
            {
                Console.WriteLine("list is empty");
                return -1;
            }
            int e = Front.element;
            Front = Front.Next;
            Size = Size - 1;
            if (IsEmpty())
                Rear = null;
            return e;
        }

        public int RemoveLast()
        {
            if(IsEmpty())
            {
                Console.WriteLine("list is empty");
                return -1;
            }

            var current = Front;
            int i = 1;

            while (i < Size - 1)
            {
                current = current.Next;
                i = i + 1;
            }

            Rear = current;
            current = current.Next;
            int e = current.element;
            Rear.Next = null;
            Size = Size - 1;
            return e;
        }

        public class Node
        {
            public int element;
            public Node Next;

            public Node(int n)
            {
                element = n;
                Next = null;
            }
        }
    }

    #endregion
}
