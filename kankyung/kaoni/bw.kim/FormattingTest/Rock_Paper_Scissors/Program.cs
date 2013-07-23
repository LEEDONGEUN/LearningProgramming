using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    class Program
    {
        //enum iphone
        //{
        //    one = "가위",
        //    two = "바위",
        //    three = "보"
        //}

        static void Main(string[] args)
        {
            int i =  0 ;
            while(true)
            {
                i++;
                Console.WriteLine("가위 바위 보 게임입니다~ 꾸미기 따위는 안드로이드로~");
                Console.Write("당신의 패는? (1: 가위, 2: 바위, 3 : 보 , quit: 종료)    : ");
                string quit = Console.ReadLine();
                
                if (quit.Equals("quit"))
                    {
                         break;
                    }
                int INTquit = int.Parse(quit);
                int INTValue = Computer(i);
//                string value = INTValue.ToString();
                
                    //iphone one = iphone.one;
                    //iphone two = iphone.two;
                    //iphone three = iphone.three;
                string STRINGQuit;
                string STRINGValue;
                   if (1 == INTquit)
                   {
                       STRINGQuit = "가위";
       
                   }
                   if (2 == INTquit )
                   {
                       STRINGQuit = "바위";

                   }
                   if (3 == INTquit)
                   {
                       STRINGQuit = "보";
  
                   }
                   if (1 == INTValue)
                   {
                       STRINGValue = "가위";

                   }
                   if (2 == INTValue)
                   {
                       STRINGValue = "바위";

                   }
                   if (3 == INTValue)
                   {
                       STRINGValue = "보";

                   }

                    if (INTquit > 3 || INTquit < 1)
                    {
                        Console.WriteLine("다시 입력해주세요~ㅠ");
                    }
                    else if (INTValue > 3 || INTValue < 1)
                    {
                        Console.WriteLine("다시 입력해주세요~ㅠ");
                    }
                    else if (INTquit == INTValue)
                    {
                        //변수값을 받아서 자동으로 프린트되게 하고 싶은데 안됨..질문할 것!
                        Console.WriteLine("내가 낸 것 : {0} ", STRINGQuit);
                        Console.WriteLine("컴퓨터가 낸 것 : {0}", STRINGValue);
                        Console.WriteLine("비겼습니다");
                    }
                    else if (INTquit < INTValue)
                    {
                        Console.WriteLine("내가 낸 것 : {0} ", INTquit.ToString());
                        Console.WriteLine("컴퓨터가 낸 것 : {0}", INTValue.ToString());
                        Console.WriteLine("졌습니다"); 
                    }
                    else if (INTquit > INTValue)
                    {
                        Console.WriteLine("내가 낸 것 : {0} ", INTquit.ToString());
                        Console.WriteLine("컴퓨터가 낸 것 : {0}", INTValue.ToString());
                        Console.WriteLine("이겼습니다");
                    }

            }
        }
            
        public static int Computer(int a)
        {
            int com = ((++a) % 3) + 1;
            return com;
            
        }
    }   
}

