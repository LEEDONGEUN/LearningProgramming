using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodtest
{
    class Program
    {
        static void Main(string[] args)
        {
            //화면에서 두 개의 숫자를 읽는다.
            string numbRead1 = Console.ReadLine();
            int n1 = Convert.ToInt32(numbRead1);
            string numbRead2 = Console.ReadLine();
            int n2 = Convert.ToInt32(numbRead2);
            //Add 메서드를 호출한다.
            int addResult = Add(n1, n2);
            Console.WriteLine("a + b: {0}", addResult);

            Console.WriteLine("안녕~~~");
        }

        static int Add(int a, int b)
        {
            // 아래와 같은 문자열을 화면에 출력한다.
            // "a + b: {0}"
            int result = a + b;
            //Console.WriteLine("a + b: {0}", a + b);
            return result;
        }
    }

    public class AnotherClass
    {
        public static void ExampleMethod(int number)
        {
            Console.WriteLine("Number + 100: {0}", (number + 100));
        }
    }
}
