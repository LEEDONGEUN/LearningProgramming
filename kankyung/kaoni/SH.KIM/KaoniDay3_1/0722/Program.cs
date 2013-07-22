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
            int i = 1;
            while (true)
            {
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("1. 가위---------------------------------");
                Console.WriteLine("2. 바위---------------------------------");
                Console.WriteLine("3. 보  ---------------------------------");
                Console.WriteLine("4. QUIT---------------------------------");
                Console.WriteLine("----------------------------------------");

                int a;
                a = Int32.Parse(Console.ReadLine());

                if (a < 1 || a > 4)
                {
                    Console.WriteLine("ERROR");
                }
                else if (a == 1)
                {
                    while (true)
                    {
                        
                        int com = ((i % 3) + 1);
                       
                        if (a == com)
                        {
                            Console.WriteLine(" 당신은 가위, 컴퓨터도 가위 ");
                            Console.WriteLine(" 비겼습니다 ");
                            i = i + 1;
                            break;
                        }
                        else if (com == 2)
                        {
                            Console.WriteLine(" 당신은 가위, 컴퓨터는 바위 ");
                            Console.WriteLine(" 졌습니다 ");
                            i = i + 1;
                            break;
                        }
                        else if (com == 3)
                        {
                            Console.WriteLine(" 당신은 가위, 컴퓨터는 보 ");
                            Console.WriteLine(" 이겼습니다 ");
                            i = i + 1;
                            break;
                        }
                    }
                }
                else if (a == 2)
                {
                    while (true)
                    {
                        
                        int com = ((i % 3) + 1);


                        if (a == com)
                        {
                            Console.WriteLine(" 당신은 바위, 컴퓨터도 바위 ");  
                            Console.WriteLine(" 비겼습니다 ");
                            i = i + 1;
                            break;
                        }
                        else if (com == 1)
                        {
                            Console.WriteLine(" 당신은 바위, 컴퓨터는 가위 ");
                            Console.WriteLine(" 이겼습니다 ");
                            i = i + 1;
                            break;
                        }
                        else if (com == 3)
                        {
                            Console.WriteLine(" 당신은 바위, 컴퓨터는 보 ");
                            Console.WriteLine(" 졌습니다 ");
                            i = i + 1;
                            break;
                        }
                    }
                }
                else if (a == 3)
                {
                    while (true)
                    {
                        
                        int com = ((i % 3) + 1);


                        if (a == com)
                        {
                            Console.WriteLine(" 당신은 보, 컴퓨터도 보 ");
                            Console.WriteLine(" 비겼습니다 ");
                            i = i + 1;
                            break;
                        }
                        else if (com == 1)
                        {
                            Console.WriteLine(" 당신은 보, 컴퓨터는 가위 ");
                            Console.WriteLine(" 졌습니다 ");
                            i = i + 1;
                            break;
                        }
                        else if (com == 2)
                        {
                            Console.WriteLine(" 당신은 보, 컴퓨터는 바위 ");
                            Console.WriteLine(" 이겼습니다 ");
                            i = i + 1;
                            break;
                        }
                    }
                }
                else if (a == 4)
                {
                    Console.WriteLine(" 종료 ");
                    break;
                }
            }
        }
    }
}


