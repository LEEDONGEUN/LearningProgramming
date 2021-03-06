﻿using System;

namespace FormatEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Currency formatting - {0:C} {1:C4}", 88.8, -888.8);
            Console.WriteLine("Integer formatting - {0:D5}", 88);
            Console.WriteLine("Exponential formatting - {0:E}", 888.8);
            Console.WriteLine("Fixed-point formatting - {0:F3}", 888.8888);
            Console.WriteLine("{0:0000.00}", 10.5);
            Console.WriteLine("{0:####.##}", 10.5);
            Console.WriteLine("{0:####.##}", 10.567);
            Console.WriteLine("General formatting - {0:G}", 888.8888);
            Console.WriteLine("Number formatting - {0:N}", 8888888.8);
            Console.WriteLine("Hexadecimal formatting - {0:X4}", 88);
            Console.WriteLine("{0:gg yyyy년 M월 d일 dddd tt h시 m분 s초 zzz}", DateTime.Now);
        }
    }
}
