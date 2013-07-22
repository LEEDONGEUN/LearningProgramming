using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step1
{
    class Program
    {
        /// <summary>
        /// 프로그램 엔트리 포인트 Main() 메서드
        /// </summary>
        /// <param name="args">프로그램의 명령 행 인자</param>
        /// 
        static void Main(string[] args)
        {

            bool whileFlag = true;
            String _day;

            while (whileFlag)
            {
                Console.WriteLine("===================================================================");
                Console.WriteLine("Input Day");
                Console.WriteLine("0. 빠져나가기");
                Console.WriteLine("1. Day1");
                Console.WriteLine("2. Day2");

                Console.Write("\n날짜 : ");
                _day = Console.ReadLine();

                if(_day == "0")
                {
                    whileFlag = false;
                }
                else if (_day == "1")
                {
                    new Day1();
                }
                else if (_day == "2")
                {
                    string temp = args[0];
                    new Day2(args[0]);
                }
                else 
                {
                    Console.WriteLine("존재 하지 않습니다.");
                }

                Console.WriteLine("\n===================================================================");
            }
        }
    }
}
