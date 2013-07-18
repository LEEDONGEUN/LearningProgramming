using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaoniDay01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Kaoni");
            Console.WriteLine();

            Console.Write("첫번째 문자열을 입력하세요 : ");
            string a = Console.ReadLine();
            Console.Write("두번째 문자열을 입력하세요 : ");
            string b = Console.ReadLine();
            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.WriteLine();
            Console.Write(a);
            Console.Write(" ");
            Console.WriteLine(b);

            Console.WriteLine();
            Console.Write("글자 하나를 입력하세요 : ");
            char i = (char)Console.Read();
            Console.WriteLine("입력하신 글자는 {0}입니다.", i);

            Console.WriteLine();
            Console.Write("0 ~ 9 사이의 수 두개를 입력하세요 : ");
            int num1 = Console.Read() - '0';
            int num2 = Console.Read() - '0';
            Console.WriteLine("{0} + {1} = {2}", num1, num2, num1+num2);
            

        }
    }
}
