using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gababo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1.당신의 패는(1:가위, 2:바위, 3:보, 4: 종료)");
            int i= 0;
            for (; ; )
            {
                int com = ((++i) % 3) + 1;
                String Game = Console.ReadLine();
                int user = int.Parse(Game);
                if (user > com && user < 4)
                {
                    Console.WriteLine("이겼습니다.");
                }
                else if (user == com && user < 4)
                {
                    Console.WriteLine("비겼습니다.");
                }
                else if (user < com && user < 4)
                {
                    Console.WriteLine("졌습니다.");
                }
                if (user == 4)
                {
                    Console.WriteLine("종료.");
                }



            }
        }
    }
}