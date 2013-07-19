using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaoniDay1
{
    class StringWrite
    {
        static void Main()
        {
            //\"는 문자열 안에 " 를 표현하고 싶을 때 사용한다.
            //\u~~~ : ~~~안에 유니코드 번호표를 넣으면 해당번호의 글자가 나옴.(띄어쓰기 없이)
            //@를 앞에 붙이면 그대로 문자열을 출력한다.
            Console.WriteLine("{0} + {1} = {2}", 100, 130, 100 + 130);
            //{}는 0부터 시작하는 자리순서??
            Console.WriteLine("\t10의 폭을 가지며, 왼쪽 정렬:\"{0,-10}", 99);
            Console.WriteLine("\"10의 폭을 가지며, 오른쪽 정렬\":{0,10}", 99);
            Console.WriteLine(@"\\ShardeFolder\download");
            Console.WriteLine(@"\ShardeFolder\download");
            Console.WriteLine("\tShardeFolder\\download");
            Console.WriteLine("\ucc28");
 
        }
    }
}
