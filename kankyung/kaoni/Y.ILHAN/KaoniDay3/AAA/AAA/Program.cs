using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA
{
    class Program
    {
        static void Main(string[] args)
        {

            string input;
            int user;
            int com;
            bool quit = false;
            Random r = new Random();
            Console.WriteLine("가위바위보게임\n");


            while (!quit)
            {
                com = r.Next(3) + 1;
                Console.WriteLine("1:가위, 2:바위, 3:보, 4:종료");
                input = Console.ReadLine();
                user = Convert.ToInt32(input);

                switch (user)
                {
                    case 4:
                        quit = true;
                        Console.WriteLine("종료");
                        break;
                    case 1:
                        if (com == 1)
                            Console.WriteLine("비겼다");
                        else if (com == 2)
                            Console.WriteLine("이겼다");
                        else
                            Console.WriteLine("졌다");
                        break;

                    case 2:
                        if (com == 1)
                            Console.WriteLine("졌다");
                        else if (com == 2)
                            Console.WriteLine("비겼다");
                        else
                            Console.WriteLine("이겼다");
                        break;

                    case 3:
                        if (com == 1)
                            Console.WriteLine("이겼다");
                        else if (com == 2)
                            Console.WriteLine("졌다");
                        else
                            Console.WriteLine("비겼다");
                        break;
                    default:
                        Console.WriteLine("재입력");
                        break;
                }
            }
        }
    }
}

 
    
