using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("2~9 사이의 숫자를 입력하세요 : ");
            int number = int.Parse(Console.ReadLine());
            if (number < 10 && number > 1)
            {
                for (int i = 1; i <= 9; i++)
                {
                    int dan = number * i;
                    Console.WriteLine("{0} X {1} = {2}", number, i, dan);
                }
            }
            else
            {
                Console.WriteLine("2~9의 숫자를 입력하세요!");
            }
        }
    }

}