using System;
using System.Collections;
using System.Collections.Generic;

namespace LinkedListBase
{


    public class LinkedList<T> : IEnumerable<Node<T>>
    {


        public Node<T>? Head { get; set; }
        public Node<T>? Tail { get; set; }
        public int Count { get; private set; }

        public LinkedList()
        {
            Count = 0;
            Head = new Node<T>(default(T));
            Tail = new Node<T>(default(T));
            Head.Next = Tail;
        }



        public IEnumerator<Node<T>> GetEnumerator()
        {
            Node<T>? currentNode = Head;
            while (currentNode != null)
            {
                yield return currentNode;
                currentNode = currentNode.Next;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public Node<T> First
        {
            get
            {
                if (Count == 0)
                {
                    return null;
                }
                return Head.Next;
            }
        }

    }
}