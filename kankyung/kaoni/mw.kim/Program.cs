﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    /// <summary>
    /// 포맷팅 문자를 위한 테스트 클래스
    /// </summary>
    class Program
    {
        /// <summary>
        /// 프로그램의 엔트리 포인트 Main()메서드
        /// </summary>
        /// <param name="args">프로그램의 명령 행 인자</param>
        static void Main(string[] args)
        {
            /*Console.WriteLine("Currency formatting - {0:C1} {1:C4}", 88.8, -888.8);
            Console.WriteLine("Integer formatting - {0:D5}", 1234567);
            Console.WriteLine("Exponential formatting - {0:E}", 888.8);
            Console.WriteLine("Fixed-point formatting - {0:F3}", 888.8888);
            Console.WriteLine("{0:0000.00}", 10.5);
            Console.WriteLine("{0:####.##}", 123456789.54321);
            Console.WriteLine("{0:####.##}", 10.567);
            Console.WriteLine("General formatting - {0:G4}", 888.8888);
            Console.WriteLine("Number formatting - {0:N}", 8888888.8);
            Console.WriteLine("Hexadecimal formatting - {0:X4}", 88);
            Console.WriteLine("{0:gggg yyyy년 M월 d일 dddd tt hh시 mm분 s초 zzz}", DateTime.Now);*/

            try
            {
                Console.WriteLine(args[0]);
             
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception at > {0}", e.StackTrace);
            }
        }
    }
}