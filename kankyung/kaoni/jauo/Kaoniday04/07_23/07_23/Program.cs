using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_23_Arry
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sort method
            int[] data = { 4, 6, 3, 8, 9, 3 };
            System.Array.Sort(data);

            //Clear
            int[] data1 = { 4, 6, 3, 8, 9, 3, };
            System.Array.Clear(data1, 3, 2);

            //clone method
            int[] data2 = { 4, 6, 3, 8, 9, 3 };
            int[] clone = (int[])data2.Clone();
            data2[2] = 100;
            data2[3] = 100;

            //GetLenght 
            int[,] data3 = { { 0, 1, 2, 3 }, { 4, 5, 6, 7, } };
            int dim0 = data3.GetLength(0); // ==2
            int dim1 = data3.GetLength(1); // ==4

            //indexOf
            int[] data4 = { 4, 6, 3, 8, 9, 3, };
            int where = System.Array.IndexOf(data, 9); // ==4
        }
    }
}
