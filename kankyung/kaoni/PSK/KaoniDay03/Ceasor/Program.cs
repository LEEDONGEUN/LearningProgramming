using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ceasor
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("당신의 패는(1:가위, 2:바위, 3:보, Quit: 종료)");
                
                int i = 0;
                var hu = new Setting();

                for ( ; ; )
                {
                    int com = (++i % 3) + 1;

                    var mm = Console.ReadLine();

                    hu.Human = int.Parse(mm);

                    if (hu.Human > com && hu.Human < 4 && hu.Human > 0)
                    {
                        Console.WriteLine("이겼습니다.");
                    }
                    else if (hu.Human.Equals(com) && hu.Human < 4 && hu.Human > 0)
                    {
                        Console.WriteLine("비겼습니다.");
                    }
                    else
                    {
                        Console.WriteLine("졌습니다.");
                    }

                    if (mm == @"Quit")
                    {
                        Console.WriteLine("종료..");
                        break;
                    }
                }
            }
            catch(FormatException)
            {
                Console.WriteLine("재실행 해주세요..");
            }
        }

        class Setting
        {
            public Setting() { }

            public int Human { get; set; }
        }
    }
}
