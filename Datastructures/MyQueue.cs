using System;
using System.Collections.Generic;

namespace Datastructures
{
    public class MyQueue<T>
    {
        public List<T> queue;
        public MyQueue() {
            queue = new List<T>();
        }

        public void Enqueue(T item)
        {
            queue.Add(item);
        }

        public T Dequeue()
        {
            T returnItem = queue[0];
            queue.Remove(returnItem);
            return returnItem;
        }

        public int Count()
        {
            return queue.Count;
        }

        public Boolean IsEmpty()
        {
            return true;
        }
    }
}
