using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arraytest
{
    class Program
    {
        static void Main(string[] args)
        {

            //Sort method
            int[] data1 = { 4, 6, 3, 8, 9, 2 };
            System.Array.Sort(data1);

            //Clear method
            int[] data2 = { 4, 6, 3, 8, 9, 2 };
            System.Array.Clear(data2, 3, 2);

            //Clone method
            int[] data3 = { 4, 6, 3, 8, 9, 2 };
            int[] clone = (int[])data3.Clone();
            data3[2] = 100;
            data3[3] = 200;


            //GetLength method
            int[,] data4 = { { 0, 1, 2, 3 }, { 4, 5, 6, 7 } };
            int dim0 = data4.GetLength(0); // ==2
            int dim1 = data4.GetLength(1); // ==4

            //IndexOf method
            int[] data5 = { 4, 6, 3, 8, 9, 2 };
            int where = System.Array.IndexOf(data5, 9); // ==4

        }
    }
}
