using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = { 4, 6, 3, 8, 9, 3 };
            System.Array.Sort(data);

            int[] data1 = { 4, 6, 3, 8, 9, 3 };
            System.Array.Clear(data1, 3, 2);

            int[] data2 = { 4, 6, 3, 8, 9, 3 };
            int[] clone = (int[])data2.Clone();
            data2[2] = 100;
            data2[3] = 200;

            int[,] data3 = { { 0, 1, 2, 3 }, { 4, 5, 6, 7 } };
            int dim0 = data3.GetLength(0);
            int dim1 = data3.GetLength(1);

            int[] data4 = { 4, 6, 3, 8, 9, 3 };
            int where = System.Array.IndexOf(data4, 9);

        }
    }
}
