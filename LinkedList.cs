using System;
using System.Collections;
using System.Collections.Generic;

namespace LinkedListBase
{


    public class CustomLinkedList<T> : IEnumerable<Node<T>>
    {


        public Node<T>? Head { get; set; }
        public Node<T>? Tail { get; set; }
        public int Count { get; private set; }

        public CustomLinkedList()
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
        public void AddFirst(Node<T> nodeToAdd)
        {
            if (Head is null)
            {
                Head = nodeToAdd;
            }
            else
            {
                nodeToAdd.Next = Head;
                Head = nodeToAdd;
            }
            Count++;
        }

        public void AddFirst(T valueToAdd)
        {
            Node<T> node = new Node<T>(valueToAdd);
            AddFirst(node);
        }

        public Node<T>? GetLastNode()
        {
            if (First is null)
            {
                return default;
            }

            var aux = First;

            while (aux is not null)
            {
                if (aux.Next is null)
                {
                    return aux;
                }

                aux = aux.Next;
            }

            return default;
        }


    }
}