using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchTest
{
    enum suit
    {
        clubs,
        hearts,
        spades,
        diamonds
    }
    class Program
    {
        static void Main(string[] args)
        {
            suit trumps = suit.hearts;
            string color;
            switch(trumps)
            {
                case suit.clubs:
                case suit.hearts:
                    color = "black";
                    break;
                case suit.spades:
                    color = "black";
                    break;
                case suit.diamonds:
                    color = "Red";
                    break;
                default:
                    color = "ERROR";
                    break;
            }
            //warling을 없애기 위해? ㅋ
            Console.WriteLine(color);

        int i = 0;
        do {
        Console.WriteLine(i);
        i++;
        
    }while( i < 10);  

            //무한루프를 만드는 형식중 하나
        while (true)
        {
            //명령을 받아라
            //명령을 해석해라
            //if (명령이 종료 명령이냐?) {
            //  yes : break;
            // } else {
            //      명령을 수행해라
            //  }
        }

        }
    }
}
