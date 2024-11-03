using System;
using System.Collections.Generic;
public interface IQueue<T>
    {
        void Enqueue(T item);
        T Dequeue();
        bool isEmpty();
    }

