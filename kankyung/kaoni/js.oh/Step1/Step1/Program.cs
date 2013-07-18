using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step1
{
    class Program
    {
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

                Console.Write("볼 날짜 : ");
                _day = Console.ReadLine();

                if(_day == "0")
                {
                    whileFlag = false;
                }
                else if (_day == "1")
                {
                    new Day1();
                }
                else 
                {
                    Console.WriteLine("존재 하지 않습니다.");
                }

                Console.WriteLine("===================================================================");
            }
        }
    }
}
