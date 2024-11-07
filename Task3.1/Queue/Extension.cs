using System;
using System.Collections;
using System.Collections.Generic;

public static class QueueExtension
{
    public static IQueue<T> Tail<T>(this IQueue<T> queue)
    {
        if (queue.isEmpty())
            throw new InvalidCastException("Queue is empty.");
            
            Queue<T> newQueue = new Queue<T>();
            T firstElement = queue.Dequeue();
        while (!queue.isEmpty())
        {
            newQueue.Enqueue(queue.Dequeue());
        }
        return newQueue;
    }
}
