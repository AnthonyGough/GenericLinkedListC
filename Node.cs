using System;

namespace LinkedListBase
{

    public class Node<T>
    {

        public T Data { get; private set; }
        public Node<T>? Next { get; private set; }

        public Node(T data) : this(data, null) { }


        public Node(T data, Node<T> next)
        {
            Data = data;
            Next = next;
        }
    }

    public class LinkedList<T> where T : IComparable
    {

    }
}