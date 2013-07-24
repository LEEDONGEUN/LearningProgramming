using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex23
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                try
                {
                    while(true)
                    {

                        Random rand = new Random();
                        int a = rand.Next(1,3);
                        Console.WriteLine("1=가위 2=바위 3=보");
                        Console.Write("숫자를 입력하세요");
                        int n = int.Parse(Console.ReadLine());
                        if (n > 3)
                        {
                            Console.WriteLine("3보다 작거나 같은 수를 입력하세요");
                        }
                        else
                        {
                            if (n == a)
                            {
                                Console.WriteLine("비겼습니다");
                                Console.WriteLine("사용자: {0}, 컴:{1}", n, a);
                            }
                            else if (n == 2 && a == 3 || n == 1 && a == 2 || n == 3 && a == 1)
                            {
                                Console.WriteLine("졌습니다");
                                Console.WriteLine("사용자: {0}, 컴:{1}", n, a);
                            }
                            else
                            {
                                Console.WriteLine("이겼습니다");
                                Console.WriteLine("사용자: {0}, 컴:{1}", n, a);
                                break;
                            }
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("문자는 입력할수없습니다");
                }
            }
        }
    }
}

