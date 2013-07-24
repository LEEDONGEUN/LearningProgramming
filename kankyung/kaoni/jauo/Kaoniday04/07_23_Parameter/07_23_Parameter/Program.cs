using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_23_Parameter
{
    class Program
    {
        static void Main(string[] args)
        {
                      
        }
        static int Add(int a, int b)
        {
            return a + b;
        }
        static string Add(string a, string b)
        {
            return string.Concat(a, b);
        }
        static int Add(int a, int b, int c)
        {
            return a + b + c;
        }
        //static int Add(int n1, int n2)
        //{
        //    return 3 + 4;
        //}
        static int Add(params int [] intArr)
        {
            int retValue = 0;
            foreach (int item in intArr)
            {
                retValue += item;
              //  retValue = retvalue + item;
            }

            return retValue;
        }

    }
}
