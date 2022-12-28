using System;
using System.Collections.Generic;
using System.Text;

namespace myfirstproject.CollectionDemo
{
    class QueueDemo1
    {
        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(5);
            q.Enqueue(56);
            q.Enqueue(89);
            q.Enqueue(23);
            foreach(var x in q)
            {
                Console.WriteLine(x);
            }
        }
    }
    class QueueDemo2
    {
        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(5);
            q.Enqueue(56);
            q.Enqueue(89);
            q.Enqueue(23);
            Console.WriteLine("Elements in queue :"+q.Count);
            foreach (var x in q)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("....................");
            Console.WriteLine("......................"+q.Dequeue());
            foreach (var x in q)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("...................."+q.Peek());
            Console.WriteLine(q.Contains(56));
            q.Clear();
            Console.WriteLine("Elements in queue :"+q.Count);
            Console.WriteLine(q.Peek());
        }
    }
}
