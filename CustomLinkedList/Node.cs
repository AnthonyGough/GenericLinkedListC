using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListBase
{
    public interface INode<T>
    {
        T Data { get; set; }
    }

    public class Node<T> : INode<T>
    {
        public T Data { get; set; }
        public Node<T>? Next { get; set; }

        public Node(T value)
        {
            Data = value;
            Next = null;
        }

        public Node(T value, Node<T> next)
        {
            Data = value;
            Next = next;
        }
    }
}