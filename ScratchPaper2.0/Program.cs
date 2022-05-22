using System;

namespace ScratchPaper2._0
{

    public class LinkedList2<T> where T : IEquatable<T>
    {
        public class Node
        {
            public Node Next;
            public T Value;
        }

        private Node Head;
        private Node Tail;
        public int Count;

        public LinkedList2()
        {
            Head = new Node();
            Tail = Head;
            Count = 0;
        }
        public void AddItemtoEnd(T item)
        {
            if (Count == 0)
            {
                AddItemtoStart(item);
                return;
            }
            else
            {
                Node newNode = new Node();
                newNode.Value = item;

                Tail.Next = newNode;
                Tail = newNode;

                Count++;
            }

        }
        public void AddItemtoStart(T item)
        {
            Node newNode = new Node() { Value = item };
            newNode.Next = Head;
            Head = newNode;

            if(Count == 0)
            {
                Tail = Head;
            }
            Count++;

        }
        public void removeItemFromStart()
        {
            if(Count > 0)
            {
                Head = Head.Next;
                Count--;
            }
            else
            {
                Console.WriteLine("No Nodes Exist");
            }
        }
        public bool containsItem(T item)
        {
            Node current = Head;

            while(current != null)
            {
                if(Equals(current.Value, item))
                {
                    return true;
                }
                current = current.Next;

            }
            return false;

        }
        public T retrieveAt(int location)
        {
            if (location > Count || location < 0) 
                throw new OutOfMemoryException("Out of index");
            

            Node current = Head;
            for(int i = 1; i < location; i++)
            {
                current = current.Next;
            }
            return current.Value;
        }
        public void printList()
        {
            Node current = Head;
            
            while(current != null)
            {
                Console.WriteLine(current.Value);
                current = current.Next;
            }

            Console.WriteLine($"Total Nodes: {Count}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList2<string> theList = new LinkedList2<string>();
            theList.AddItemtoStart("Refresh 1");
            theList.AddItemtoEnd("Refresh 2");
            theList.AddItemtoEnd("Refresh 3");
            theList.AddItemtoEnd("Refresh 4");
            

            theList.printList();

            Console.WriteLine(theList.containsItem("Refresh 1"));

            Console.WriteLine($"Retrieve Refresh 2: {theList.retrieveAt(2)}");

            Console.WriteLine();

            theList.removeItemFromStart();

            theList.printList();
            Console.WriteLine(theList.containsItem("Refresh 1"));

            Console.WriteLine(theList.retrieveAt(3));


        }
    }
}
