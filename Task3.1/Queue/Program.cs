using System;

class Program {
    static void Main(string[] args) 
    { 
     Queue<int> queue = new Queue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(5);
        queue.Enqueue(8);

        Console.WriteLine("Original Queue: ");
        while (!queue.isEmpty())
        {
            Console.WriteLine(queue.Dequeue());
        }

        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(5);
        queue.Enqueue(8);
        IQueue<int> tailQueue = queue.Tail();
        Console.WriteLine("Tail Queue: ");
        while (!tailQueue.isEmpty())
        {
            Console.WriteLine(tailQueue.Dequeue());
        }

    }

}
