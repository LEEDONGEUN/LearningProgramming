using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaoniDay03_Gagobo
{
    class Gababo
    {
        static void Main(string[] args)
        {
            String user;
            int com, i=0;

            while (true)
            {
                Console.Write("당신의 패는?(1:가위, 2:바위, 3:보, Quit:종료) ");
                user = Console.ReadLine();
                com = ((++i)%3)+1;

                if (user.ToLower() == "quit")
                {
                    Console.WriteLine("가위바위보를 종료합니다.");
                    break;
                }
                else if (user == com.ToString())
                {
                    Console.WriteLine("USER : {0}, COM : {1}", user, com);
                    Console.WriteLine("비겼습니다.\n");
                }
                else if (user == "1" && com == 3 || user == "2" && com == 1 || user == "3" && com == 2)
                {
                    Console.WriteLine("USER : {0}, COM : {1}", user, com);
                    Console.WriteLine("이겼습니다.\n");
                }
                else if (user == "1" && com == 2 || user == "2" && com == 3 || user == "3" && com == 1)
                {
                    Console.WriteLine("USER : {0}, COM : {1}", user, com);
                    Console.WriteLine("졌습니다.\n");
                }
                else
                {
                    Console.WriteLine("1~3까지의 숫자나 quit만 입력하세요.\n");
                }
            }
        }
    }
}
