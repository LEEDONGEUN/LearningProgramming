using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HK_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i=0; i >= 0; i++)
            {
                string game = Console.ReadLine();
                if (game == "가위")
                {
                    if ((i % 3) + 1 == 1)
                    {
                        Console.WriteLine("당신이 이겼습니다.");
                    }
                    else if( (i%3)+1 == 2)
                    {
                        Console.WriteLine("비겼습니다.");
                    }
                    else if ((i % 3) + 1 == 3)
                    {
                        Console.WriteLine("당신이 졌습니다.");
                    }
                }
                else if (game == "바위")
                {
                    if ((i % 3) + 1 == 1)
                    {
                        Console.WriteLine("비겼습니다.");
                    }
                    else if ((i % 3) + 1 == 2)
                    {
                        Console.WriteLine("당신이 졌습니다.");
                    }
                    else if ((i % 3) + 1 == 3)
                    {
                        Console.WriteLine("당신이 이겼습니다.");
                    }
                }
                else if (game == "보")
                {
                    if ((i % 3) + 1 == 1)
                    {
                        Console.WriteLine("당신이 졌습니다.");
                    }
                    else if ((i % 3) + 1 == 2)
                    {
                        Console.WriteLine("비겼습니다.");
                    }
                    else if ((i % 3) + 1 == 3)
                    {
                        Console.WriteLine("당신이 이겼습니다.");
                    }
                }
                else if (game == "Quit")
                {
                    i = -2;
                }
                
            }
        }
    }
}
