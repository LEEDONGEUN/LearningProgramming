using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodParameter
{
    class Program
    {
        static int Add (int a, int b)
        {
            return a + b;
        }
        static string Add (string a, string b)
        {
            return String.Concat(a, b);
        }
        //static int Add(int n1, int n2) { }
        static int Add (int a, int b, int c)
        {
            return a + b + c;
        }
        static int Add(params int[] intArr)
        {
            int retValue = 0;
            foreach (int item in intArr)
            {
                retValue += item;
            }
        }

        static void Main(string[] args)
        {
            ParamsMethod(1, 4, 5, 3);
        }
        static void ParamsMethod(int a, int b, params int[] intArr)
        {
            Console.WriteLine(Add(1, 2) + Add(1, 2, 3));
        }
    }
}
