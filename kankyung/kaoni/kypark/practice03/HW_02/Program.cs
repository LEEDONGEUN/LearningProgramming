using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("가위, 바위, 보, 그만 중에 하나를 입력하세요.");
            int i;
            for (i = 0; i >= 0; i++)
            {
                string game = Console.ReadLine();
                if (game == "그만")
                {
                    i = -2;
                }
                else
                {
                    if ((i % 3) + 1 == 1)
                    {
                        if (game == "바위")
                        {
                            Console.WriteLine("컴퓨터 : 바위 - 비겼습니다.");
                        }
                        if (game == "가위")
                        {
                            Console.WriteLine("컴퓨터 : 바위 - 당신이 졌습니다.");
                        }
                        if (game == "보")
                        {
                            Console.WriteLine("컴퓨터 : 바위 - 당신이 이겼습니다.");
                        }
                    }
                    else if ((i % 3) + 1 == 2)
                    {
                        if (game == "바위")
                        {
                            Console.WriteLine("컴퓨터 : 가위 - 당신이 이겼습니다.");
                        }
                        if (game == "가위")
                        {
                            Console.WriteLine("컴퓨터 : 가위 - 비겼습니다.");
                        }
                        if (game == "보")
                        {
                            Console.WriteLine("컴퓨터 : 가위 - 당신이 졌습니다.");
                        }
                    }
                    else if ((i % 3) + 1 == 3)
                    {
                        if (game == "바위")
                        {
                            Console.WriteLine("컴퓨터 : 보 - 당신이 졌습니다.");
                        }
                        if (game == "가위")
                        {
                            Console.WriteLine("컴퓨터 : 보 - 당신이 이겼습니다.");
                        }
                        if (game == "보")
                        {
                            Console.WriteLine("컴퓨터 : 보 - 비겼습니다.");
                        }
                    }
                }
            }
        }
    }
}
