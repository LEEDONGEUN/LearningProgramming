using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0722
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int k=0;
          

            Console.Write("출력할 단을 입력하세요:\t");
            String n = Console.ReadLine();
            int a = Convert.ToInt32(n);
            
	        for(int j=1; j<=9; j++)
	        {
                k = a * j;
		        Console.WriteLine("{0} * {1} = {2}", a,j,a*j);
	        }
	        Console.WriteLine();
            */
            
            int user;
            bool quit=true;
            Console.WriteLine("입력하세요.");
		

			while(quit)
			{
				int i =0;
				int com = ((++i)%3)+1;
				Console.WriteLine("가위=1,바위=2,보=3,끝내기=0");
                string k = Console.ReadLine();
                int input = Convert.ToInt32(k);
				user=Convert.ToInt32(input);

                switch (user)
                {
                    case 0:
                        quit = false;
                        Console.WriteLine("종료");
                        break;
                    case 1:
                        if (com == 1)
                            Console.WriteLine("비겼습니다.");
                        else if (com == 2)
                            Console.WriteLine("이겼습니다.");
                        else
                            Console.WriteLine("졌습니다.");
                        break;
                    case 2:
                        if (com == 1)
                            Console.WriteLine("졌습니다.");
                        else if (com == 2)
                            Console.WriteLine("비겼습니다.");
                        else
                            Console.WriteLine("이겼습니다.");
                        break;
                    case 3:
                        if (com == 1)
                            Console.WriteLine("이겼습니다.");
                        else if (com == 2)
                            Console.WriteLine("졌습니다.");
                        else
                            Console.WriteLine("비겼습니다.");
                        break;
                    default:
                        Console.WriteLine("숫자를 다시 입력해주세요.");
                        break;

                }
			}

		}
	}
}