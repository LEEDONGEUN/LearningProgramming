using System;
using System.Collections.Generic;


namespace EXG02
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue <int>que = new Queue<int>();
             que.Enqueue(1);
             que.Enqueue(2);
             que.Enqueue(3);
             que.Enqueue(4);
             que.Enqueue(5);
             while (que.Count > 0)
                 Console.WriteLine(que.Dequeue());
        }
        }

    }

