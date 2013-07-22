using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20130722_report
{
    class Program
    {

        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine(random.Next() + "\n\n\n\n\n\n"); 

            gugudan(Int32.Parse(Console.ReadLine()));

            game();
        }

        static public void gugudan(int dan)
        {
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", dan, i, dan * i);
            }
        }

        static public void game()
        {
            bool Flag = true;
            int i = 0;

            while (Flag)
            {
                Console.WriteLine("1. 가위, 2. 바위, 3. 보, 4.종료");

                String myHand = Console.ReadLine();
                String comHand = getHand(i);

                switch (myHand)
                {
                    case "가위":  // 가위
                        if (comHand == "가위")
                        {
                            Console.WriteLine("비겼습니다");
                        }
                        else if (comHand == "바위")
                        {
                            Console.WriteLine("패 하였습니다");
                        }
                        else if (comHand == "보")
                        {
                            Console.WriteLine("승리 하였습니다");
                        }
                        break;
                    case "2": // 바위
                        if (comHand == "가위")
                        {
                            Console.WriteLine("승리 하였습니다");
                        }
                        else if (comHand == "바위")
                        {
                            Console.WriteLine("비겼습니다");
                        }
                        else if (comHand == "보")
                        {
                            Console.WriteLine("패 하였습니다");
                        }
                        break;
                    case "3": // 보
                        if (comHand == "가위")
                        {
                            Console.WriteLine("패 하였습니다");
                        }
                        else if (comHand == "바위")
                        {
                            Console.WriteLine("승리 하였습니다");
                        }
                        else if (comHand == "보")
                        {
                            Console.WriteLine("비겼습니다");
                        }
                        break;
                    case "4":
                        Flag = false;
                        break;
                }

                i++;

            }
        }

        static public String getHand(int count)
        {
            switch ((count % 3) + 1)
            {
                case 1:
                    return "가위";
                case 2:
                    return "바위";
                case 3:
                    return "보";
                default:
                    return "가위";
            }

        }
    }
    
}
