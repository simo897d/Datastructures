using System;
using System.Collections.Generic;

namespace Datastructures
{
    public class MyStack<T>
    {
        private List<T> stack;
        public MyStack() {
            stack = new List<T>();
        }

        public void Push(T item)
        {
            stack.Add(item);
        }

        public T Pop()
        {
            T lastItem = stack[Count() - 1];
            stack.RemoveAt(Count() - 1);
            return lastItem;
        }

        public T Peek()
        {
            return stack[Count() - 1];
        }

        public int Count()
        {
            return stack.Count;
        }
    }
}
