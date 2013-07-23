using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormattingTest
{
    /// <summary>
    /// 포맷팅 문자를 위한 테스트 클래스
    /// </summary>
    class Program
    {
        /// <summary>
        /// 프로그램의 엔트리 포인트 Main()메서드
        /// </summary>
        /// <param name="args">프로그램의 명령 행 인자</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Currency formatting - {0:C} {1:C4}", 88.8, -888.8);
            //결과값 : Currency formatting - \89 -\888.8000  
            //숫자를 통화량을 나타내는 문자열로 변환합니다.
            //OS에 따라 결과가 달라질 수 있다. \가 $로 된다던지 미국같은 cent까지 쓰는 국가에선 소수점까지 결과값이 나오는거 같다.

            Console.WriteLine("Integer formatting - {0:D5}", 88);
            //결과값 : Integer formatting - 00088
            //정수 계열 형식에만 사용 가능. 숫자를 10진수(0-9) 문자열로 변환하며, 숫자가 음수이면 앞에 빼기 부호가 붙습니다.

            Console.WriteLine("Exponential formatting - {0:E}", 888.8);
            //결과값 : Exponential formatting - 8.888000E+002

            Console.WriteLine("Fixed-point formatting - {0:F3}", 888.8888);
            //결과값 : Fixed-point formatting - 888.889
            //전체 자릿수 지정자는 필요한 소수 자릿수를 나타냄.
            Console.WriteLine("{0:0000.00}", 10.5);
            //결과값 : 0010.50

            Console.WriteLine("{0:####.##}", 10.5);
            //결과값 : 10.5
            // #의 형식만큼 결과값을 표현. 아래는 소수점을 두 자리로 표현하라고 되어 있으므로 10.567 -> 10.56으로 출력됨.
            Console.WriteLine("{0:####.##}", 10.567);
            //결과값 : 10.57

            Console.WriteLine("General formatting - {0:G}", 888.8888);
            //결과값 : General formatting - 888.8888

            Console.WriteLine("Number formatting - {0:N}", 8888888.8);
            //결과값 : Number formatting - 8,888,888.80
            //숫자를 d,ddd,ddd.ddd.. 형태의 문자열로 변환

            Console.WriteLine("Hexadecimal formatting - {0:X4}", 88);
            //결과값 : Hexadecimal formatting - 0058
            // 10진수에서만 가능. 16진수로 변환
            Console.WriteLine("{0:gg yyyy년 M월 d일 dddd tt h시 m분 s초 zzz}", DateTime.Now);
            //결과값 : 서기 2013년 7월 19일 금요일 오후 5시 28분 36초 +09:00
        }
    }
}