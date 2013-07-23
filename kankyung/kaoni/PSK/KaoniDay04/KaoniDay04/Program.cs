using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KaoniDay04
{
    class Program
    {
        private static List<string> ArrList { get; set; } // 제네릭 대표적인 List<T> 이용.. ArrayList 컬렉션과 같음..

        static void Main(string[] args)
        {
            ArrList = new List<string>(); // 프로퍼티 초기화 (개체 화) NullReferenceException

            ArrList.Add(@"목록 1");
            ArrList.Add(@"목록 2");
            ArrList.Add(@"목록 3");

            foreach (var v in ArrList) // in 키워드를 이용한 List<T> 에서 추가시킨 항목 (item) 들 출력..
            {
                Console.WriteLine(v);
            }

            Console.WriteLine("\n\n-------------------------------------------\n\n");

            int[] ss = {3, 4, 5};
            Console.WriteLine(AddSub(3, ss));
            Console.WriteLine(AddSub("ww", "ss"));
            Console.WriteLine(AddSub(1, 2, 3));
            Console.WriteLine(AddSub(3, 5));

            Console.WriteLine("\n\n-------------------------------------------\n\n");

            Array.Sort(DataList());
            Array.Clear(DataList(), 0, DataList().Length);
            var clone = (int[])DataList().Clone();

            foreach(var v in clone)
            {
                Console.Write("{0} ", v);
            }
            var where = Array.IndexOf(DataList(), 9);

            int[,] data = { {0, 1, 2, 3}, {4, 5, 6, 7}};
            var dm0 = data.GetLength(0);
            var dm1 = data.GetLength(1);
        }

        private static int MeMe(int i, ref int s, params List<int>[] f) // params 키워드는 일반 타입 배열 이외에도 제네릭 배열도 적용 된다.
        {                                       // ref 키워드는 using 네임스페이스에 상주하는 여러 타입을 지원한다.
            // work
            return 0;
        }

        private static int AddSub(int a, int b)
        {
            return a * b;
        }

        private static string AddSub(string a, string b)
        {
            return string.Format("{0} {1}", a, b);
        }

        private static int AddSub(int a, int b, int c)
        {
            return a + b + c;
        }

        private static int AddSub(int a, params int[] b)
        {
            int dd = 0;
            foreach (var c in b)
            {
                dd += c;
            }
            return dd * a;
        }

        private static int[] DataList()
        {
            int[] data = { 4, 6, 3, 8, 9, 3 };

            return data;
        }
    }
}
