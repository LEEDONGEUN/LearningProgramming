using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rndNumber = new Random();
            int userNumber;              //사용자가 입력한 숫자
            int computerNumber;         //컴퓨터가 만들어낸 숫자
            string input;              //사용자(키보드)로부터 입력받을 문자열변수
            bool quit = false;           //프로그램을 끝내기 위한 bool변수

            Console.WriteLine("가위 바위 보중 하나를 선택해 주세요.");


            while (!quit)  //quit가 true이면 빠져 나갑니다.
            {
                computerNumber = rndNumber.Next(3) + 1;
                Console.WriteLine("1:가위,2:바위,3:보,끝내기=0");
                input = Console.ReadLine();
                userNumber = Convert.ToInt32(input);  //string 을 int32형으로 바꿔준다.

                switch (userNumber)
                {
                    case 0:
                        quit = true;
                        Console.WriteLine("종료합니다.");
                        break;
                    case 1:
                        if (computerNumber == 1)
                            Console.WriteLine("컴퓨터와 당신이 비겼군요.");
                        else if (computerNumber == 2)
                            Console.WriteLine("컴퓨터가 당신을 이겼군요.");
                        else
                            Console.WriteLine("컴퓨터가 당신에게 졌습니다.");
                        break;
                    case 2:
                        if (computerNumber == 1)
                            Console.WriteLine("컴퓨터가 당신에게 졌습니다.");
                        else if (computerNumber == 2)
                            Console.WriteLine("컴퓨터가 당신과 비겼군요.");
                        else
                            Console.WriteLine("컴퓨터가 당신에게 이겼군요.");
                        break;
                    case 3:
                        if (computerNumber == 1)
                            Console.WriteLine("컴퓨터가 에게 이겼군요,");
                        else if (computerNumber == 2)
                            Console.WriteLine("컴퓨터가 당신에게 졌군요.");
                        else
                            Console.WriteLine("컴퓨터와 당신이 비겼네요.");
                        break;
                    default:
                        Console.WriteLine("0~3사이의 값을 다시 넣어 주세요.");
                        break;
                }

            }

        }
    }
}
