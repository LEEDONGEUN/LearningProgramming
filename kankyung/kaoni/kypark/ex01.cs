using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pactice01
{
    class ex01
    {
        static void Main(string[] args)
        {
            //string greeting = "Hellow, world";
            //Console.WriteLine(greeting);
            //string greeting2 = Console.ReadLine();
            //string greeting3 = Console.ReadLine();
            //Console.WriteLine(greeting2);
            //Console.WriteLine(greeting3);
            //int i, j;
            //Console.WriteLine("{0} + {1} = {2}", 90000000000000, 30, 130);
            //Console.WriteLine("\t\t10의 폭을 가지며, 왼쪽 정렬:\t\t{0,-30}", 99);
            //Console.WriteLine("\ucc2810의 폭을 가지며, 오른쪽 정렬:\ucc28:{0,20}", 99);
            //Console.WriteLine(@"\\SharedFolder\download");

            string name = "kwang yeol Park";
            Console.WriteLine(name);
            string string1 = "park";
            Console.Write(string1);
            string string2 = " kwang yeol";
            Console.WriteLine(string2);
            int i;
            for (i = 1; i <= 3; i++)
            {
                int dan = 2 * i;
                Console.WriteLine("{0} X {1} = {2}", 2, i, dan);
            }
            Console.WriteLine("\"38의 폭을 가지며, 오른쪽 오른쪽 정렬\":{0,38}", "hello");

            Console.Write("곱할 숫자를 입력하시요:");
            string num = Console.ReadLine();
            Console.Write("곱할 숫자를 입력하시요:");
            string num2 = Console.ReadLine();
            int dan2 = int.Parse(num) * int.Parse(num2);
            Console.WriteLine("{0} X {1} = {2}", num, num2, dan2.ToString());
        }
    }
}