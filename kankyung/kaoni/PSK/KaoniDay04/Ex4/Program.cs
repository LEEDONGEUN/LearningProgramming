using System;
using HashTable = System.Collections.Hashtable;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            var hs = new HashTable();
            hs[1] = "하나";
            hs[2] = "둘";
            hs[3] = "셋";
            hs[4] = "넷";
            hs[5] = "다섯";

            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine(hs[i]);
            }
            Console.WriteLine("\n\n");

            GenDic.Start();
        }
    }

    static class GenDic
    {
        public static void Start()
        {
            var hs = new Dictionary<int, string>();

            hs[1] = "하나";
            hs[2] = "둘";
            hs[3] = "셋";
            hs[4] = "넷";
            hs[5] = "다섯";

            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine(hs[i]);
            }
        }
    }
}
