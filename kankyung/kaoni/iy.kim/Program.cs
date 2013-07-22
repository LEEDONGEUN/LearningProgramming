using System;

namespace project2
{
    class program
    {
        static void Main(string[] args)
        {
            int i = 0;
            bool t = true;
            while (t) {
                
                int comValue = (++i % 3) + 1; 
      
                Console.Write("1.가위, 2.바위 3.보 4. quit(끝내기) >> ");
               
                int state = int.Parse(Console.ReadLine());

                switch (state) { 
                    case 1:
                        if (comValue == 1)
                        {
                            Console.WriteLine("나 : 가위 VS 컴 : 가위, 결과 : 비겼다");
                        }
                        else if (comValue == 2)
                        {
                            Console.WriteLine("나 : 가위 VS 컴 : 바위, 결과 : 졌다");
                        }
                        else
                        {
                            Console.WriteLine("나 : 가위 VS 컴 : 보, 결과 : 이겼다");
                        }
                        break;
                    case 2:
                        if (comValue == 1)
                        {
                            Console.WriteLine("나 : 바위 VS 컴 : 가위, 결과 : 이겼다");
                        }
                        else if (comValue == 2)
                        {
                            Console.WriteLine("나 : 바위 VS 컴 : 바위, 결과 : 비겼다");
                        }
                        else
                        {
                            Console.WriteLine("나 : 바위 VS 컴 : 보, 결과 : 졌다");
                        }
                        break;
                    case 3:
                        if (comValue == 1)
                        {
                            Console.WriteLine("나 : 보 VS 컴 : 가위, 결과 : 졌다");
                        }
                        else if (comValue == 2)
                        {
                            Console.WriteLine("나 : 보 VS 컴 : 바위, 결과 : 이겼다");
                        }
                        else
                        {
                            Console.WriteLine("나 : 보 VS 컴 : 보, 결과 : 비겼다");
                        }
                        break;
                    case 4:
                        t = false;
                        break;
                }  
            } 
        }
    }
}










