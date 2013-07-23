using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = Add(1, 2);
            int n2 = Add(1, 2, 3);
            string n3 = Add("Hello, ", "world");
            int n4 = Add(1, 1);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
        }

        public static int Add(int a, int b)
        {
            int d = a - b;
            return d;
        }

        public static string Add(string a, string b)
        {
            string e=a+b;
            return e;
        }

        public static int Add(int a, int b, int c)
        {
            int f=a+b+c;
            return f;
        }

        public static int Add(params int[] intArr)
        {
            //int Arr, i;
            //for (i = 0, Arr = 0; i < intArr.Length; i++)
            //{
            //    Arr += intArr[i];
            //}
            int Plus = 0;
            foreach (int item in intArr)
            {
                Plus += item;
            }
            return Plus;
        }
    }
}
