using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            // a: 1, b: 4, 나머지 5,3이 intArr에 들어감
            ParamsMethod(1, 4, 5, 3);

            int ret1 = Add(1, 2, 3, 4, 5);
            int[] iarr = new int[5] { 1, 2, 3, 4, 5 };
            int ret2 = Add(iarr);
        }

        static int Add(int a, int b) {
            int[] iarr = { a, b };
            return Add(iarr);
        }

        static string Add(string a, string b) {
            return String.Concat(a, b);
        }

        static int Add(int a, int b, int c) {
            return a + b + c;
        }

        //static int Add(int n1, int n2) {
        //    return 1;
        //}

        static int Add(params int[] intArr) {
            int retValue = 0;
            foreach (int item in intArr)
            {
                //retValue += item;
                retValue = retValue + item;                                
            }
            return retValue;
        }

        // note: params 키워드의 인자는 함수의 맨 마지막에 사용함.
        static void ParamsMethod(int a, int b, params int[] intArr)
        {
        }
    }
}
