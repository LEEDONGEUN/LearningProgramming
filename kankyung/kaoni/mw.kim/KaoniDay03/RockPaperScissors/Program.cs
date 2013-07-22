using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Result();
        }

        static int Select()
        {
            
            Console.WriteLine(" 1.가위 2.바위 3.보 4.종료");
            Console.Write(" 무엇을 내겠습니까? ");
            string a = Console.ReadLine();
            int Num = int.Parse(a);
            Console.WriteLine();
           
            return Num;
        }

        static void Result()
        {

            do
            {
                Random RD = new Random(unchecked((int)DateTime.Now.Ticks));
                int i = RD.Next(1, 4);
                              
                int Num = Select();

                if (Num == 4)
                {
                    break;
                }
                else if ((Num == 1) && (i == 3))
                {
                    Console.WriteLine("플레이어 : 가위");
                    Console.WriteLine("컴 퓨 터 :  보");
                    Console.WriteLine("플레이어가 승리하였습니다.");
                    Console.WriteLine();
                }
                else if ((Num == 1) && (i == 1))
                {
                    Console.WriteLine("플레이어 : 가위");
                    Console.WriteLine("컴 퓨 터 : 가위");
                    Console.WriteLine("비겼습니다.");
                    Console.WriteLine();
                }
                else if ((Num == 1) && (i == 2))
                {
                    Console.WriteLine("플레이어 : 가위");
                    Console.WriteLine("컴 퓨 터 : 바위");
                    Console.WriteLine("컴퓨터가 승리하였습니다.");
                    Console.WriteLine();
                }
                else if ((Num == 2) && (i == 1))
                {
                    Console.WriteLine("플레이어 : 바위");
                    Console.WriteLine("컴 퓨 터 : 가위");
                    Console.WriteLine("플레이어가 승리하였습니다.");
                    Console.WriteLine();
                }
                else if ((Num == 2) && (i == 2))
                {
                    Console.WriteLine("플레이어 : 바위");
                    Console.WriteLine("컴 퓨 터 : 바위");
                    Console.WriteLine("비겼습니다.");
                    Console.WriteLine();
                }
                else if ((Num == 2) && (i == 3))
                {
                    Console.WriteLine("플레이어 : 바위");
                    Console.WriteLine("컴 퓨 터 :  보");
                    Console.WriteLine("컴퓨터가 승리하였습니다.");
                    Console.WriteLine();
                }
                else if ((Num == 3) && (i == 2))
                {
                    Console.WriteLine("플레이어 :  보");
                    Console.WriteLine("컴 퓨 터 : 바위");
                    Console.WriteLine("플레이어가 승리하였습니다.");
                    Console.WriteLine();
                }
                else if ((Num == 3) && (i == 3))
                {
                    Console.WriteLine("플레이어 :  보");
                    Console.WriteLine("컴 퓨 터 :  보");
                    Console.WriteLine("비겼습니다.");
                    Console.WriteLine();
                }
                else if ((Num == 3) && (i == 1))
                {
                    Console.WriteLine("플레이어 :  보");
                    Console.WriteLine("컴 퓨 터 : 가위");
                    Console.WriteLine("컴퓨터가 승리하였습니다.");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("다시 입력하세요");
                    Console.WriteLine();
                }
            } while (true);
        }
    }
}
