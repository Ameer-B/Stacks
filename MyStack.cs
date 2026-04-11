using System;
using System.Collections.Generic;
using System.Text;

namespace Stacks
{
    public class MyStack<T>
    {
        public int Count { get; private set; }
        private LinkedList<T> data = new LinkedList<T>();

        public MyStack() 
        {
        }
        public void Push(T value) 
        {
            data.AddLast(value);
            Count++;
        }
        public T Pop() 
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Empty Stack");
            }

            T returnValue = data.Head.Previous.Value;
   
            data.RemoveLast();
            Count--;
            return returnValue;
        }
        public T Peek() 
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Empty Stack");
            }

            return data.Head.Previous.Value;
        }

        // Optional Functions
        public void Clear()
        {
            data.Clear();

            Count = 0;
        }
        public bool IsEmpty() 
        {
            return data.Count == 0;
        }
    }
}
