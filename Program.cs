using System;

namespace LinkedList
{

    class List
    {
        Node Head;
        Node Tail;

        public List()
        {
            Head = Tail = null;
        }

        public void AddInFirst(int value)
        {
            Node item = new Node(value);
            if (Head == null)
            {
                Head = item;
                Tail = item;
            }
            else
            {
                item.Next = Head;
                Head = item;
            }
        }

        public void AddInEnd(int value)
        {
            Node item = new Node(value);
            if (Head == null)
            {
                Head = item;
                Tail = item;
            }
            else
            {
                Tail.Next = item;
                Tail = item;
            }
        }

        public void Display()
        {
            Node Start = Head;
            if (Start == null)
            {
                System.Console.WriteLine("Empty");
            }
            else
            {
                while (Start != null)
                {
                    System.Console.WriteLine(Start.Data);
                    Start = Start.Next;
                }
            }
        }

        public void Search(int value)
        {
            Node current = Head;
            int pos = 1;
            while (current != null)
            {
                if (current.Data == value)
                {
                    System.Console.WriteLine($"item {value} founded in position {pos}");
                    return;
                }
                current = current.Next;
                pos++;
                if (current == null)
                {
                    System.Console.WriteLine("not founded !");
                }

            }
        }

        public void Remove(int value)
        {
            if (Head == null)
            {
                System.Console.WriteLine("List Empty");
            }
            if (Head.Data == value)
            {
                Head = Head.Next;
                return;
            }
            Node Previos = Head;
            Node Current = Head.Next;
            while (Current != null)
            {
                if (Current.Data == value)
                {
                    Previos.Next = Current.Next;
                    if (Previos.Next == null)
                    {
                        Tail = Previos;
                    }
                    return;
                }
                Previos = Previos.Next;
                Current = Current.Next;

            }
            if (Current == null)
            {
                System.Console.WriteLine("Not founded");
            }
        }
    }


    class Node
    {
        int data;
        Node next;

        public int Data
        {
            get { return data; }
            set { data = value; }
        }

        public Node Next
        {
            get { return next; }
            set { next = value; }
        }

        public Node(int valuee)
        {
            this.data = valuee;
            next = null;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            // int[] arr = new int[5]{1,2,3,4,5};
            // var x = Array.IndexOf(arr,3);
            // Console.WriteLine(x);
            // Node one = new Node(1);
            // Node two = new Node(2);
            // Node three = new Node(3);
            // one.Next = two;
            // two.Next = three;
            // Console.WriteLine(one.Next.Next.Data);

            List l = new List();
            l.AddInFirst(5);
            l.AddInFirst(10);
            l.AddInEnd(15);
            l.Search(10);
            l.Remove(100);
            l.AddInEnd(30);
            l.Display();
        }
    }
}
