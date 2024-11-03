using System;
using System.Collections.Generic;

public class Queue<T> : IQueue<T>
{
    private LinkedList<T> elements = new LinkedList<T>();
    public void Enqueue(T item)
    {
       elements.AddLast(item);
       
    }

    public bool isEmpty()
    {
        return elements.Count == 0;
    }

    public T Dequeue()
    {
        if (isEmpty())
            throw new InvalidOperationException("Queue is empty.");
        T value = elements.First.Value;
        elements.RemoveFirst();
        return value;
    }
}

