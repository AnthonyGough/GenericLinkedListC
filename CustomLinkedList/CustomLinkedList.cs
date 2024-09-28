using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Channels;

namespace LinkedListBase
{


    public class CustomLinkedList<T> : IEnumerable<Node<T>>
    {


        public Node<T>? Head { get; set; }
        public Node<T>? Tail { get; set; }
        public int Count { get; set; }

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
                return Head;
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

        public void AddAfter(Node<T> insertionPoint, Node<T> nodeToAdd)
        {

            try
            {
                if (First is null)
                {
                    throw new InvalidOperationException("Linked list contains no nodes");
                }
                else
                {
                    Node<T> currentNode = First;
                    while (currentNode is not null)
                    {
                        if (currentNode.Equals(insertionPoint))
                        {
                            if (!currentNode.Equals(Tail))
                            {
                                Node<T>? nextNode = currentNode.Next;
                                currentNode.Next = nodeToAdd;
                                nodeToAdd.Next = nextNode;
                            }
                            else
                            {
                                currentNode.Next = nodeToAdd;
                                Tail = nodeToAdd;
                            }
                        }
                    }
                }
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Linked list is empty - cannot add node at location", e);
            }
        }

        public void AddBefore(Node<T> nodeToAdd, Node<T> insertionPoint)
        {

        }

        public void AddLast(Node<T> nodeToAdd)
        {

        }

        public void Clear()
        {
            Count = 0;
            Head = null;
            Tail = null;
        }

        public bool Contains(Node<T> comparisonNode)
        {

        }

        public void CopyTo(T[] array, int index)
        {

        }

        public Node<T> Find(T value)
        {

        }

        public void Remove(Node<T> nodeToRemove)
        {

        }

        public Node<T>? GetLastNode()
        {
            if (First is null)
            {
                return default;
            }

            Node<T> tmp = First;

            while (tmp is not null)
            {
                if (tmp.Next is null)
                {
                    return tmp;
                }

                tmp = tmp.Next;
            }

            return default;
        }


    }
}