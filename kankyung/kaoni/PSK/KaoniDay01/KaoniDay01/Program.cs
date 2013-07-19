using System; // System 네임 스페이스 (Reference System.Dll 이 들어와 있을 때 사용 가능.)
using Console = System.Console; // System 네임스페이스에 포함된 Console 클래스 만을 이용 함.

namespace KaoniDay01 // 사용자가 직접 사용하고 있는 프로젝트 네임스페이스 이름. 프로젝트 내에서 맴버 단위로 공유하며 사용이 됨.
{
    class Program // 클래스 
    {
        private static int Ii { get; set; } // 프로퍼티, 일반적으로 쓰이는 타입 변수보다 효율성과 데이터 보존성이 좋음. 해당 필드 영역에만 사용이 가능 하도록 private 한정자로 지정 했음. 타입은 명시적으로 줘야 함.
        private static int Jj { get; set; } // 프로퍼티가 주로 사용 할 메서드가 정적 메서드 일 때, static으로 지정 하도록 권장하고 있다. 

        static void Main(string[] args) // Main 메서드 C#에서는 메서드를 정의 할 때 기본적으로 앞문자를 대문자로 하도록 되어 있음. 모든 클래스를 실행 하고자 할 때에는 반드시 같은 솔루션 내에 한개의 Main() 메서드에서 실행해야 한다.
        {
            int i = 1; // 일반 벨류형 변수, 정수형
            int j = 2;

            Ii = i;
            Jj = j;

            Console.WriteLine(@"{0} + {1} = {2, 5}", Ii, Jj , Ii+Jj);
            // @"" 형식은 file path나 URI 형식을 지정 할 때에도 사용이 되나, 리펙터링 기법에서 위와 같이 사용해도 문제가 발생하지 않는다. (단, \일 때에는 그냥 문자로 인식한다.)
            // Console.WriteLine() 은 string.Format() 과 같은 방식을 취하고 있다.
            
            var b = Console.ReadLine(); // MSDN 기준에서 데이터를 레퍼런스 타입인 string 으로 입력 받는다.
            Console.WriteLine("{0}", b);

            var a = Console.Read(); // MSDN 기준에서도 Console 클래스 내에 있는 Read() 메서드는 입력받은 한 문자를 16진수로 값을 가지게 된다고 함. 타입은 당연히 int로 표현되어 있다. 기본 초기값은 -1이다.
            Console.WriteLine("{0}", a); // ex) a를 입력 받을때, 97로 출력이 됨. (16진수 → 10진수)

            Console.WriteLine("\uAF43 {0}송이", 1); // \u는 유니코드 변환 할 때 사용한다.
            
        }
    }
}
