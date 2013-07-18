using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program03
{
    class Hello
    {
             static void Main()
        {
            string greeting = "Hello, world";
            Console.WriteLine("{0}+{1}={2}", 100, 130, 100 + 130); //0 "첫번째" 1 "두번째" 2 "세번째"
            Console.WriteLine("\"10의 폭을 가지며,왼쪽정렬:\"{0,-10}", 99); //w t 는 tab들어게 됨 
            Console.WriteLine("\"10의 폭을 가지며,오른쪽정렬:\"{0,10}", 99);
            Console.WriteLine(@"\\Shaed Folder\\download"); //@ 넣으면 그대로 출력

                                    
        }

    }
}
