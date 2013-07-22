using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("구하실 단의 숫자를 입력하세요");

            int gugu = int.Parse(Console.ReadLine());

            switch (gugu)
            {
                case 2:
                    for (int i = 1; i <= 9; i++)
                    {
                        Console.WriteLine("{0} * {1} = {2}", gugu, i, gugu * i);
                    };
                    break;
                case 3:
                    for (int i = 1; i <= 9; i++)
                    {
                        Console.WriteLine("{0} * {1} = {2}", gugu, i, gugu * i);
                    };
                    break;
                case 4:
                    for (int i = 1; i <= 9; i++)
                    {
                        Console.WriteLine("{0} * {1} = {2}", gugu, i, gugu * i);
                    };
                    break;
                case 5:
                    for (int i = 1; i <= 9; i++)
                    {
                        Console.WriteLine("{0} * {1} = {2}", gugu, i, gugu * i);
                    };
                    break;
                case 6:
                    for (int i = 1; i <= 9; i++)
                    {
                        Console.WriteLine("{0} * {1} = {2}", gugu, i, gugu * i);
                    };
                    break;
                case 7:
                    for (int i = 1; i <= 9; i++)
                    {
                        Console.WriteLine("{0} * {1} = {2}", gugu, i, gugu * i);
                    };
                    break;
                case 8:
                    for (int i = 1; i <= 9; i++)
                    {
                        Console.WriteLine("{0} * {1} = {2}", gugu, i, gugu * i);
                    };
                    break;
                case 9:
                    for (int i = 1; i <= 9; i++)
                    {
                        Console.WriteLine("{0} * {1} = {2}", gugu, i, gugu * i);
                    };
                    break;
                default :
                    Console.WriteLine("2~9 사이의 숫자만 입력하시기 바랍니다");
                    break;
            }
        }
    }
}
