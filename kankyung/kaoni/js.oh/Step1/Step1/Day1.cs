using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step1
{
    class Day1
    {
        public Day1() 
        {
            Console.WriteLine("Day1. String, 입출력");

            if (!Information())
                Console.WriteLine("읽기 실패");
            
        }

        public bool Information() 
        {
            try
            {
                // String Print
                String msg = "Hello World!";
                Console.WriteLine(msg);

                // 문장 입력 받기
                Console.Write("문자열 입력 : ");
                String temp1 = Console.ReadLine();
                Console.WriteLine("출력 : " + temp1);

                // 글자 입력 받아 아스키 코드로 출력
                
                int temp2;
                Console.Write("문자열 입력 : ");
                while(true){
                    temp2 = Console.Read();
                    if (temp2 != 13)
                        Console.WriteLine("출력 : " + temp2);
                    else
                        break;
                }

                

                // \, " 활용
                Console.WriteLine("-------------인수 전달(숫자)-------------");
                Console.WriteLine("{0}, {1}, {2}, {3}, {4}", 1,2,3,4,5+2);

                Console.WriteLine("-------------인수 전달(글자)-------------");
                Console.WriteLine("{0}, {1}, {2}, {3}, {4}", 'a', 'b', 'c', 'd', 'e');

                Console.WriteLine("-------------TAB 출력-------------");
                Console.WriteLine("\t\t1");

                Console.WriteLine("-------------쌍 따음표 출력-------------");
                Console.WriteLine("\"ok");

                Console.WriteLine("-------------역슬래시 출력-------------");
                Console.WriteLine(@"\\192.168.0.1");

                Console.WriteLine("-------------유니코드 출력-------------");
                Console.WriteLine("\u0097");

               
                return true;
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.StackTrace);
                return false;
            }
        }
    }
}
