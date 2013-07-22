using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0722_1
{
    class Program
    {

        static void multi(int a)
        {
            for (int b = 1; b < 10; b++)
            {
                Console.WriteLine(" {0} * {1} = {2}", a, b, a * b);

            }
        }

        static void Main(string[] args)
        {

            Console.WriteLine(" 2부터 9까지의 숫자를 입력하세여 ");
            int a;
            a = Int32.Parse(Console.ReadLine());
            multi(a);
        }
    }
}

