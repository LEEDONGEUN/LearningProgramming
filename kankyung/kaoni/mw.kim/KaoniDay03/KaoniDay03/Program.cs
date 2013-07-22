using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" 구 구 단 ");
            int n = InPut();
            Multiplication(n);
            
        }

        static int InPut()
        {
            Console.Write("숫자를 입력하세요: ");
            int Num = Console.Read() - '0';
            return Num;
        }

        static void Multiplication(int n)
        {
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", n, i, (n * i));
            }
        }
    }
}
