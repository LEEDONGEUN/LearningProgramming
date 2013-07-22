using System;

namespace KaoniDays02
{
    class Program
    {
        enum Color // enum은 나중에 컨트롤 단위로 조작 구현 할때 많이 쓰임.. (ex.. 미디어 플레이어 앱에서 재생, 일시정지, 다음 곡 등 과 같은 버튼들을 구현 할 때)
        {           // enum은 내부 Type인 int 형을 기반으로 두고 있음.. 첫번째 열거 부분이 보통 0부터 시작함..
                    // http://msdn.microsoft.com/ko-kr/library/sbbt4032(v=vs.100).aspx
            Red = 1,
            Green = 2,
            Blue = 3
        }

        public struct Emp // http://msdn.microsoft.com/ko-kr/library/ah19swz4(v=vs.100).aspx 구조체 관련 설명..
        {
            public string Name;
            public int Age;

            public Program Prog { get; set; } // 구조체 내에서는 메서드나 프로퍼티도 적용 가능하다..
        }

        static void Main(string[] args)
        {
            var blue = Color.Blue; // 타입은 명시적으로 지정 되어있기 때문에.. var를 사용.. 
            Console.WriteLine("{0}", blue);

            var ee = new Emp(); // Emp ee 와 1차적으로는 같음.. 구조체는 Class와 비슷하게 쓰여지고, 또한 한정자에 민감하지만, Value Type 기반이다.
            var name = ee.Name = "smith";
            var age = ee.Age = 1;

            Console.WriteLine("{0}, {1}", name, age);
        }
    }
}
