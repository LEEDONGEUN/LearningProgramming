using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaonIDay02
{
    /// <summary>
    /// 과제과제과제
    /// </summary>
    class Program
    {
        /// <summary>
        /// 프로그램의 엔트리 포인트 
        /// </summary>
        public struct Employee
        {
            public string firstName;
            public int age;
        }
        
        enum Color { Red = 10, Green = 100, Blue = 200 }
        
        
        static void Main(string[] args)
        {
            Employee companyEmployee;
	        companyEmployee.firstName = "Joe";
	        companyEmployee.age = 23;
            Console.WriteLine(companyEmployee.firstName + "는" + companyEmployee.age + "살");

            Color colorPalette = Color.Red;
            Console.WriteLine("{0}", colorPalette);
            
            int ItemCount = 10, i = 20, j = 30;
            ItemCount = ItemCount + 40;
            int x = i * 3 + j * 5;
            int y = i * (3 + j) * 5;
            Console.WriteLine(ItemCount + "  " + x + "  " + y);

            Console.WriteLine("100 + " + " 130 = " + " 230 ");
            Console.WriteLine("100+130=230");

            Console.WriteLine("Currency formatting1 - {0:C} {1:C4}", 88.8, -888.8);
            Console.WriteLine("Currency formatting2 - {0:C} {1:C9}", 88.8, -888.8);

            Console.WriteLine("Integer formatting1 - {0:D1}", 88);
            Console.WriteLine("Integer formatting2 - {0:D9}", 88);

            Console.WriteLine("Exponential formatting1 - {0:E}", 888.8);
            Console.WriteLine("Exponential formatting2 - {0:E5}", 888.8);

            Console.WriteLine("Fixed-point formatting1 - {0:F3}", 888.8888);
            Console.WriteLine("Fixed-point formatting2 - {0:F9}", 888.8888);

            Console.WriteLine("{0:0000.00}", 10.5);
            Console.WriteLine("{0:00.00}", 10.5);
            Console.WriteLine("{0:####.##}", 10.5);
            Console.WriteLine("{0:####.##}", 10.567, "{0:####.##}", 10.567);
            Console.WriteLine("General formatting - {0:G}", 888.8888);
            Console.WriteLine("Number formatting - {0:N}", 8888888.8);
            Console.WriteLine("Hexadecimal formatting - {0:X4}", 88);
            Console.WriteLine("{0:gg yyyy년 M월 d일 dddd tt h시 m분 s초 zzz}", DateTime.Now);

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
