using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaoniDay01
{
    class Day01
    {
        static void Main(string[] args)
        {
            Console.Write(@"\\\\\");
            Console.Write("\uc0ac\uce59\uc5f0\uc0b0 계산기");
            Console.WriteLine(@"\\\\\");
            Console.WriteLine("정수 두개를 입력하세요");
            Console.Write("정수1 : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("정수2 : ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("\t\t{0, -3} + {1, 3} = {2, 5}", num1, num2, num1 + num2);
            Console.WriteLine("\t\t{0, -3} - {1, 3} = {2, 5}", num1, num2, num1 - num2);
            Console.WriteLine("\t\t{0, -3} / {1, 3} = {2, 5}", num1, num2, num1 / num2);
            Console.WriteLine("\t\t{0, -3} * {1, 3} = {2, 5}", num1, num2, num1 * num2);
        }
    }
}
