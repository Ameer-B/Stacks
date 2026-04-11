using System;
using System.Collections.Generic;
using System.Text;

namespace Stacks
{
    internal class LinkedList<T> 
    {
        public int Count { get; private set; }

        public Node<T> Head { get; private set; }

        public void AddFirst(T value) //add a new head at the beginning of the list
        {
            if (Head == null)
            {
                Head = new Node<T>(value);
                Head.Previous = Head;
                Head.Next = Head;

            }
            else
            {
                Node<T> newNode = new Node<T>(value);
                newNode.Next = Head;
                newNode.Previous = Head.Previous;
                Head.Previous = newNode;
                Head = newNode;
            }
            Head.ParentList = this;

            Count++;
        }

        public void AddBefore(Node<T> node, T value) //add a new node before any specified (and extant) node
        {
            if (Head == node)
            {
                AddFirst(value);
            }
            else
            {
                Node<T> newNode = new Node<T>(value);
                Node<T> mover = Head;

                while (mover != null && mover.Next != node)
                {
                    mover = mover.Next;
                }
                if (mover != null)
                {
                    mover.Next = newNode;
                    node.Previous = newNode;
                    newNode.Next = node;
                    newNode.ParentList = this;
                    Count++;
                }
            }
        }

        public void AddLast(T value) //add a new tail at the end of the list
        {
            Node<T> newNode = new Node<T>(value);
            if (Head == null)
            {
                Head = newNode;
            }
            if (Head.Previous == null)
            {
                Head.Previous = newNode;
            }
            else
            {
                Head.Previous.Next = newNode;
                newNode.Previous = Head.Previous;
                Head.Previous = newNode;
                newNode.Next = Head;
            }

            
            newNode.ParentList = this;
            Count++;
        }

        public void AddAfter(Node<T> node, T value)  //add a new node after any specified (and extant) node
        {
            if (Head.Previous == node)
            {
                AddLast(value);
                return;
            }

            Node<T> newNode = new Node<T>(value);
            newNode.Next = node.Next;
            node.Next = newNode;
            newNode.Previous = node;
            newNode.ParentList = this;

            Count++;
        }


        public bool RemoveFirst()  //remove the first node
        {
            T numb = Head.Value;
            if (Head.Next == null)
            {
                Clear();
                Count--;
                return true;
            }

            if (Head != null)
            {
                Head.Next.Previous = Head.Previous;
                Head = Head.Next;
                Head.Previous.Next = Head;
                Count--;
                return true;
            }
            else
            {
                return false;
            }
            

        }


        public bool RemoveLast()  //remove the last node 
        {

            if (Head.Next == null)
            {
                Clear();
                return true;
            }


            Head.Previous = Head.Previous.Previous;
            Head.Previous.Next = Head;

            Count--;
            return true;


        }


        public bool Remove(T value)  //find and remove a node containing the given value
        {
            Node<T> mover = Head;

            if (Head == null)
            {
                return false;
            }

            if (Head.Value.Equals(value) == true)
            {
                RemoveFirst();
            }
            else if (Head.Previous.Value.Equals(value) == true)
            {
                RemoveLast();
            }
            else
            {
                if (mover != null && mover.Value.Equals(value) == false)
                {
                    mover = mover.Next;
                }
                mover.Next = mover.Next.Next;
                mover.Next.Previous = mover;
                Count--;
            }

            return true;
        }

        public void Clear()  //delete every node in the linked list
        {
            Head = null;
            Count = 0;
        }

        public Node<T> Search(T value)  //search for a given value and return a node that contains it, return null if none is found
        {
            Node<T> mover = Head;


            while (mover != null && mover.Value.Equals(value) == false && mover != Head.Previous)
            {
                mover = mover.Next;
            }
            if (mover == Head.Previous && mover.Value.Equals(value) == false)
            {
                return null;
            }
            return mover;


        }

        public bool ContainsUsingValue(T value) //search for a given value and return true if you found it.
        {
            return (Search(value) != null);
        }

        public bool ContainsUsingNode(Node<T> node)  //Check if the given node belongs to this list in O(1) time
        {

            if (node.ParentList == Head.ParentList)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
