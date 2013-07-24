using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jagged = new int[4][];
            jagged[0] = new int[6] { 7, 6, 98, 100, 3, 18 };
            jagged[1] = new int[] { 4, 8, 9, 5 };
            jagged[2] = new int[] { 20, 50 };
            jagged[3] = new int[] { 44, 66, 55 };

            foreach (int[] arr in jagged)
            {
                Console.Write("Length : {0}, ", arr.Length);
                foreach (int e in arr)
                {
                    Console.Write("{0} ", e);
                }
                Console.WriteLine("");
            }

            Console.WriteLine("");

            int[][] jagged2 = new int[2][] {
                new int[] { 2000, 5000}, 
                new int[5] { 20, 50, 40, 90, 80 } };

            foreach (int[] arr in jagged2)
            {
                Console.Write("Length : {0}, " , arr.Length);
                foreach (int e in arr)
                {
                    Console.Write("{0} ", e);
                }
                Console.WriteLine();
            }
        }
    }
}
