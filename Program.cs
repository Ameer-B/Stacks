namespace Stacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> ListStack = new MyStack<int>();
            Stack<int> ArrayStack  = new Stack<int>();
/*
            ListStack.Pop();
            ListStack.Push(1);
            ListStack.Push(10);
            ListStack.Push(74);
            ListStack.Push(42);
            ListStack.Push(4);
            ListStack.Pop();
            ListStack.Peek();
            */
            //-----------------------------------------
           ArrayStack.Push(4);
            ArrayStack.Push(5);
            ArrayStack.Push(6);
            ArrayStack.Push(7); 
            ArrayStack.Push(8);
            ArrayStack.Push(1);
            ArrayStack.Push(32);
            ArrayStack.Push(12);
            ArrayStack.Push(98);
            ArrayStack.Push(24);
            ArrayStack.Push(54);
            ArrayStack.Push(21);
            ArrayStack.Pop();
            ArrayStack.Peek();
        }
    }
}
