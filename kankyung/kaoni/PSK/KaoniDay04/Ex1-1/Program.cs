using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>();
            for (int i = 0; i < 5; i++)
                list.Add(i);
            

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
