using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex03_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList Arr = new ArrayList();
            Arr.Add(1);
            Arr.Add("Hello");
            Arr.Add("1");
            foreach (var yo in Arr)
            {
                Console.WriteLine(yo);
                Console.WriteLine(Arr.Count);
            }
            Console.WriteLine("--------------------------------------");
            //int[] row = { 0, 1, 2, 3 };
            //int[] row1 = new int[4] { 0, 1, 2, 3 };
            //int c = row.Length;
            //Console.WriteLine(c);
            //int[,] row2 = { { 1, 2, 3 }, { 4, 5, 6 } };
            //int d = row2.Length;
            //Console.WriteLine(d);

            int[] data = { 4, 5, 6, 7, 3, 2, 1, 7, 4, 2, 7, 3, 45, 7 };
            Array.Sort(data);
            foreach (int item in data)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------------------------");

            int[] data1 = { 4, 5, 3, 4, 6, 7, 2 };
            Array.Clear(data1, 3, 2);
            foreach (int item in data1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------------------------");

            int[] data2 = { 4, 5, 3, 4, 6, 7, 2 };
            int[] clone = (int[])data2.Clone();
            data2[0] = 100;
            data2[1] = 150;
            int[,] data3 = { { 0, 1, 2, 3 }, { 5, 6, 7, 8 } };
            int dim0 = data.GetLength(0);
            int dim1 = data.GetLength(0);

            int[] data4 = { 4, 6, 3, 8, 9, 3 };
            int where = Array.IndexOf(data4, 3);
        }
    }
}