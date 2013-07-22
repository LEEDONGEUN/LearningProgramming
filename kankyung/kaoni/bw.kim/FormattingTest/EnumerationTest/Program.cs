using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//사용자 정의 type은 거의 3개만 쓴다(enum , struct , class)
namespace EnumerationTest
{
    class Program
    {
        //Main 밖에서 선언해야 한다.(메서드 안에서 선언 불가!)
        //enum Color { Red, Green, Blue }
        //enum Color를 선언하였으면 Color의 스펙을 설정해줘야한다.

        enum Color { Red = 10, Green = 100, Blue = 200 }

        static void Main(string[] args)
        {
            Color colorPalette = Color.Red;

            Console.WriteLine("{0}", colorPalette);   // 결과값 Red
            Console.WriteLine("{0}", (int)colorPalette);     // 결과값  10, 강제 형변환

        }
    }
}
