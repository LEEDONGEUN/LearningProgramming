using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_22_HW_3
{
    class Program
    {
   
        static void Main(string[] args)
        {
            int userNum;
            int ComNUm;
            string input;
            bool quit = false;

            Random rndNumber = new Random();
            
            Console.WriteLine("가위 = 1, 바위 = 2, 보 = 3 THE End = 0");
            Console.WriteLine("컴퓨터와 가외바위보 숫자를 입력하시오 ");

            while (!quit)
            { 
                ComNUm = 1;
                ComNUm = rndNumber.Next(3) + 1;
                input = Console.ReadLine();
                userNum=Convert.ToInt32(input);

                switch(userNum)
                {
                    case 0:
                        quit = true;
                        break;
                    case 1:
                        if(ComNUm == 1)
                        Console.WriteLine("컴퓨터와 당신이 가위를 내서 비겼습니다.");
                       
                        else if (ComNUm == 2)
                        Console.WriteLine("컴퓨터는 주먹을 내고 당신은 가위를 내서 당신이 졌습니다.");
                        
                        else if (ComNUm == 3)
                        Console.WriteLine("컴퓨터는 보를 내고 당신은 가위를내서 당신이 이겼습니다.");
                        break;
                    case 2:
                        if (ComNUm == 1)
                        Console.WriteLine("컴퓨터는 가위를 내고 당신은 주먹을 내서 당신이 이겼습니다..");

                        else if (ComNUm == 2)
                        Console.WriteLine("컴퓨터와 당신이 주먹을 내서 비겼습니다.");

                        else if (ComNUm == 3)
                        Console.WriteLine("컴퓨터가 보를내고 당신이 주먹을내서 졌습니다.");
                        break;
                    case 3:
                        if (ComNUm == 1)
                        Console.WriteLine("컴퓨터가 가위를내고 당신이 보를 내서 졌습니다.");
                        
                        else if(ComNUm == 2)
                        Console.WriteLine("컴퓨터가 주먹을내고 당신이 보를 내서 이겼습니다.");
                        
                        else if (ComNUm == 3)
                        Console.WriteLine("컴퓨터와 당신이 보를 내서 비겼습니다.");
                        break;
                    default:
                        Console.WriteLine("0~3사이의 값을 다시 넣어 주세요.");
                        break;

                
                }
            }              
        }
    }
}
