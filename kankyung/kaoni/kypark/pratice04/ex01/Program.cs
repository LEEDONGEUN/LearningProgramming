using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Average(63, 21, 84, 1, 3, 4, 5, 6, 7, 3, 4);
            Console.WriteLine(x);
        }

        public static int Average(params int[] v)
        {
            int total, i, aver;
            for (i = 0, total = 0; i < v.Length; i++)
            {
                total += v[i];
            }
            aver = total / v.Length;
            return aver;
        }
    }
}