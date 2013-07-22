using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwichTest
{
    enum suit
    {
        Clubs,
        Hearts,
        Spades,
        Diamonds,
    } ;
    class Program
    {
        static void Main(string[] args)
        {
            suit Trumps = suit.Hearts;
            string color;
            switch (Trumps) //  코드 조각 ( Tab 를 두번 눌러 사용) 자주쓰는 코드를 스튜디오가 포함하고있다 
            {
                case suit.Clubs:
                case suit.Spades:
                    color = "Black";
                    break; // case 에서는 실행문장이 잇으면 꼭 break!!

                case suit.Hearts:
                case suit.Diamonds:
                    color = "Red";
                    break;
                default:
                    color = "ERROR";
                    break;

            }
            Console.WriteLine(color);
            /*int i = 0;
            do
            {
                Console.WriteLine(i);
                i++; // while문에서 거짓값을 안만들어주면 무한루프가 된다 ..
            }
            while (i < 10);*/

            //while (true)
            {
                //명령을 받아라
                //명령을 해석해라 
                // if (명령이 종료명령이냐?)
                {
                    //     yes :break;
                    //} else { 
                    // 명령을 수행하라 
                    // }
                }
                try
                {

                }
                catch (Exception caught)
                {
                }    
                    finally  // try 를 하던 catch를 하던지관여안하는 요소를 적는다  (ex 네트워크 파일 DB)

                {
                }

                }
            }
        }
    }
}