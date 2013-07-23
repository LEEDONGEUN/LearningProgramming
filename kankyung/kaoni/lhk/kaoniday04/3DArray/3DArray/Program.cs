using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[, ,] array = new int[3, 3, 3]
            {
                { { 1, 2, 3}, {4, 5, 6}, {7, 8, 9} },
                { { 4, 6, 3}, {2, 1, 5}, {8, 3, 2} },
                { { 8, 3, 5}, {3, 1, 2}, {1, 3, 7} },
            };
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("{ ");
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        Console.Write("{0}", array[i, j, k]);
                    }
                    Console.Write("} ");
                }
                Console.WriteLine();
            }
        }
    }
}
