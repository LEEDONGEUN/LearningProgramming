using System;
using System.Collections.Generic;
using ArrayList = System.Collections.ArrayList;
using System.Linq;
using System.Text;
using Parallel = System.Threading.Tasks.Parallel;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList();
            
            for (int i = 0; i < 5; i++)
            {
                list.Add(i);
            }

            foreach (var obj in list)
            {
                Console.Write("{0} ", obj);
            }
            Console.Write("\n\n");

            list.RemoveAt(2);

            foreach (var obj in list)
            {
                Console.Write("{0} ", obj);
            }
            Console.Write("\n\n");

            list.Insert(2, 2);

            foreach (var obj in list)
            {
                Console.Write("{0} ", obj);
            }
            Console.Write("\n\n");

            list.Add("aaa");
            list.Add("zzz");

            foreach (var obj in list)
            {
                Console.Write("{0} ", obj);
            }
            Console.Write("\n\n");

            Parallel.For(0, list.Count, i => // 병렬 for문.. 정렬이 잘 안됨.ㅋㅋㅋㅋ
                {
                    Console.Write("{0} ", list[i]);
                });
            Console.Write("\n\n------------------------------\n\n");

            GenList.Start();
            
        }
    }

    public static class GenList
    {
        public static void Start()
        {
            var list = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                list.Add(i);
            }

            foreach (var v in list)
            {
                Console.Write("{0} ", list);
            }
            Console.Write("\n\n");

            list.RemoveAt(2);

            foreach (var v in list)
            {
                Console.Write("{0} ", list);
            }
            Console.Write("\n\n");

            list.Insert(2, 10);

            foreach (var v in list)
            {
                Console.Write("{0} ", list);
            }
            Console.Write("\n\n");
        }
    }
}
