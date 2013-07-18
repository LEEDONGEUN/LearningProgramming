// 이동은 7.18일 복습 관련 주석처리 및 복습 외 기타 응용법 공부
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hellovs
{
    class Hello
    {
        public static int month = 7;
        static void Main()
        {
            //Console.Read();
            /*
            Console.WriteLine("Hello,World");
            Console.WriteLine(month.ToString());
            int a = Console.Read();
            int b = Console.Read();
            Console.WriteLine(a);
            Console.WriteLine(b);
            */
            //Read 와 ReadLine 활용 
            /*
            string greeting = "hello, World";
            Console.WriteLine("greeting");
            Console.WriteLine(month.ToString());
            string greeting2 = Console.ReadLine();
            string greeting3 = Console.ReadLine();
            Console.WriteLine(greeting2);
            Console.WriteLine(greeting3);

            */
            // string greeting = "hello, World";
            Console.WriteLine("Hello,World");
            Console.WriteLine(month.ToString());
            Console.WriteLine("{0}+{1}={2}", 100, 130, 100 + 130);
            //0번째부터 0,1,2 숫서로 가며 {1}+{2}={3}을하게 될경우에 3번째 수가 없기에 에러가 뜨게 된다.
            Console.WriteLine("\"10의폭을 가지며, 왼쪽 정렬:\"{0,-10}", 99);
            Console.WriteLine("\"10의폭을 가지며, 오른쪽 정렬:\"{0,10}", 99);
            //\를 사용시에 특별히 취급됨에따라 {0,-10}하게될경우 --왼쪽정렬:"99
            //{0,10}의경우에는 --오른쪽 정렬:"            99
            Console.WriteLine("\"{0,-10}", 99);
            Console.WriteLine("\"{0,10}", 99);
            //"99
            //"             99
            Console.WriteLine("\t10의폭을 가지며, 왼쪽 정렬:\"{0,-10}", 99);
            Console.WriteLine("\t\t10의폭을 가지며, 오른쪽 정렬:\"{0,10}", 99);
            Console.WriteLine("\ucc2810의폭을 가지며, 왼쪽 정렬:\"{0,-10}", 99);
            //\다음은 특별하게 취급하라

            Console.WriteLine(@"\\Shared Folder\download");
            //@특별하게 취급하지마라. 뒤에있는 그대로 출력하라
            Console.WriteLine(@"\tShared Folder\download");
            //-----------------------기타 응용-----------------------------------
            int a = 1;
            int b = 2;
            int c = 3;
            int d = 4;
            Console.WriteLine("{0},{1},{2},{3}", a, b, c, d);
            Console.WriteLine("{0:D5}", a);                 //10진수 표현
            Console.WriteLine("{0:x8}", a);                 //16진수 표현
            Console.WriteLine("{0:D5}", b);
            Console.WriteLine("{0:x8}", b);

            Console.Write(":");

            int n = Int32.Parse(Console.ReadLine());
            for (int idx = 0; idx <= n; idx++)  
            {
                  for (int i = n - idx; 0 <= i; --i)
                {
                    for (int j = 0; j < i; j++) 
                    {
                        Console.Write(" ");
                    }
                    for (int k = 0; k < idx; k++)   
                    {
                        Console.Write("*");
                    }
                    for (int p = 1; p < idx; p++)   
                    {
                        Console.Write("*");
                    }
                    break;
                  }
                 Console.WriteLine();
            }
        }
    }
}

