using System;
using System.Collections.Generic;
using System.Text;

namespace Stacks
{
    internal class Node<T> 
    {
        public Node<T> Next { get; set; }
        public Node<T> Previous { get; set; } // the only change

        public LinkedList<T> ParentList { get; set; } = new LinkedList<T>();

        public T Value { get; set; }

        public Node(T value)
        {
            Value = value;
            Next = null;
            Previous = null;
        }
    }
}
