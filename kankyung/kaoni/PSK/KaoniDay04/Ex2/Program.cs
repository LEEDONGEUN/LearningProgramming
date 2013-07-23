using System;
using Queue = System.Collections.Queue;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            var qu = new Queue();
            qu.Enqueue(1);
            qu.Enqueue(2);
            qu.Enqueue(3);
            qu.Enqueue(4);
            qu.Enqueue(5);

            while (qu.Count > 0) // while문보다 for문이 안정적임..
            {
                Console.Write("{0} ", qu.Dequeue());
            }
            Console.Write("\n\n");

            GenQueue.Start();
        }
    }

    static class GenQueue
    {
        public static void Start()
        {
            var qu = new Queue<int>();

            qu.Enqueue(1);
            qu.Enqueue(2);
            qu.Enqueue(3);
            qu.Enqueue(4);
            qu.Enqueue(5);

            while (qu.Count > 0)
            {
                Console.Write("{0} ", qu.Dequeue());
            }
        }
    }
}
