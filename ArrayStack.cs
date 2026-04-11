using System;
using System.Collections.Generic;
using System.Text;

namespace Stacks
{
    internal class ArrayStack
    {
        public class Stack<T>
        {
            public int Count { get; private set; }
            private T[] data = new T[10];
            int stackTop;
            int dataCapacity = 10;

            public Stack(int capacity = 10)
            {
            }
            public void Push(T value)
            {
                if(data.Length == 0)
                {
                    data[0] = value;
                    stackTop = 0;
                }
                else
                {
                    data[data.Length - 1] = value;
                    stackTop = data.Length - 1;
                }
                if(data.Length > dataCapacity)
                {
                    Resize();
                    dataCapacity *= 2;
                }

            } 
            public T Pop()
            {
                stackTop = data.Length - 2;
                return data[^2];
            }
            
            public T Peek()
            {
                return data[^1];
            }
            
            private void Resize()
            {
                T[] tempData = new T[data.Length * 2];
                for(int i= 0; i < data.Length; i++)
                {
                    tempData[i] = data[i];
                }
                data = tempData;
            }

            /*
            // Optional Functions
            public void Clear() { ... }
            public bool IsEmpty() { ... }
            */
        }
    }
}
