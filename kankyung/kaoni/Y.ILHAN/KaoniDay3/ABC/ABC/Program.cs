using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC
{



    class Program
    {
        static void Main(string[] args)
        {



            //while (true)
            //{
            //    int i = 0;
            //    Console.WriteLine(i);
            //    i++;
            //    if (i < 4)
            //        continue;
            //    else
            //        break;
            //}

            Console.WriteLine("가위바위보게임\n");
            Console.WriteLine("가위:1 바위:2 보:3 종료:4 중에 선택\n");
            string s = Console.ReadLine();
            int a = Convert.ToInt32(s);
            Console.WriteLine("나는{0}", a);
            int b;
            Random r = new Random();
            b = r.Next(3) + 1;
            Console.WriteLine("컴퓨터{0}", b);



            while (b == 1)
            {
                switch (a)
                {
                    case 1:
                        Console.WriteLine("나{0} 컴퓨터{1}", a, b);
                        Console.WriteLine("비겼습니다\n");
                        break;
                    case 2:
                        Console.WriteLine("나{0} 컴퓨터{1}", a, b);
                        Console.WriteLine("이겼습니다\n");
                        break;
                    case 3:
                        Console.WriteLine("나{0} 컴퓨터 {1}", a, b);
                        Console.WriteLine("졌습니다\n");
                        break;
                }
                break;
            }
            while (b == 2)
            {
                switch (a)
                {
                    case 1:
                        Console.WriteLine("나{0} 컴퓨터{1}", a, b);
                        Console.WriteLine("졌습니다\n");
                        break;
                    case 2:
                        Console.WriteLine("나{0} 컴퓨터{1}", a, b);
                        Console.WriteLine("비겼습니다\n");
                        break;
                    case 3:
                        Console.WriteLine("나{0} 컴퓨터 {1}", a, b);
                        Console.WriteLine("이겼습니다\n");
                        break;
                }
                break;
            }
            while (b == 3)
                switch (a)
                {
                    case 1:
                        Console.WriteLine("나{0} 컴퓨터{1}", a, b);
                        Console.WriteLine("이겼습니다\n");
                        break;
                    case 2:
                        Console.WriteLine("나{0} 컴퓨터{1}", a, b);
                        Console.WriteLine("졌습니다\n");
                        break;
                    case 3:
                        Console.WriteLine("나{0} 컴퓨터 {1}", a, b);
                        Console.WriteLine("비겼습니다\n");
                        break;
                }

        }



    }
}


            
            //switch (n)
            //{
            //    case 1:
            //        sKind = "가위";
            //        Console.WriteLine("이겼다");
            //        break;
            
            //    case 2:
            //        sKind = "바위";
            //        Console.WriteLine("비겼다");
            //        break;
                
            //    case 3:
            //        sKind = "보";
            //        Console.WriteLine("졌다");
            //        break;
            //    default:
            //        Console.WriteLine("올바르지 않음");
            //        break;
            //}
        
        
       // }
   // }
//}
