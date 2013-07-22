using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step1
{
    /// <summary>
    /// 포맷팅 문자를 위한 테스트 클래스
    /// </summary>
    class Day2
    {
        private string data;

        public Day2()
        {
            col1();
            col2();
            col3();
        }
        public Day2(string _data) 
        {
            this.data = _data;
            col1();
            col2();
            col3();
            col4();
        }
        private void col1() 
        {
            Console.WriteLine("col1. 숫자 Formatting \n");

            Console.WriteLine("Currency formatting - {0:C} {1:C4}", 88.8, -888.8);
            Console.WriteLine("Integer formatting - {0:D5}", 8888);
            Console.WriteLine("Exponential formatting - {0:E}", 888.8);
            Console.WriteLine("Fixed-point formatting - {0:F3}", 888.8888);
            Console.WriteLine("{0:0000.00}", 10.5);
            Console.WriteLine("{0:####.##}", 10.5);
            Console.WriteLine("{0:####.##}", 10.567);
            Console.WriteLine("General formatting - {0:G}", 888.8888);
            Console.WriteLine("Number formatting - {0:N}", 8888888.8);
            Console.WriteLine("Hexadecimal formatting - {0:X4}", 88);
            // h : 12시제, H : 24시제
            Console.WriteLine("{0:gg yyyy년 M월 d일 dddd tt H시 m분 s초 zzz}", DateTime.Now);

            Console.WriteLine("\n\n\n");
        }

        private void col2() 
        {
            Console.WriteLine("col2. 예외처리");
            try
            {
                String temp = "a";
                Int32.Parse(temp);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            finally 
            {
                Console.WriteLine("\n\n\n");
            }
        }

        private void col3() 
        {
            Console.WriteLine("값 입력 받기");

            Console.WriteLine(data);
        }
        public struct emp
        {
            public int a;
            public int b;


            public bool checkFlag() 
            {
                return true;
            }
        }
        public void col4() 
        {
            aaa colorPalette = aaa.Blue23;

            string temp = aaa.Blue23.ToString() + aaa.red + aaa.Green;
            Console.WriteLine("\n\n\n\n" + temp);

            int ab = (int)aaa.Green;

            Console.WriteLine("{0}", colorPalette);

            Console.WriteLine(ab);

            emp []aa = new emp[10];

            aa[0].a = 1;

        }
        private enum aaa { 
            red,
            Green,
            Blue23,
            sdf
        }
       
    }
}
