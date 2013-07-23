using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_22_04Method
{
    class Program
    {
        public class asdclass
        {
            public static void ExampleMethod(int number)
            {
                Console.WriteLine("number + 100 : {0} " , (number + 100).ToString());

            }
        }
        static void Main(string[] args)
        {
           // string readmsg = Console.ReadLine();

           //int n = int.Parse(readmsg)          
           //또는
           // int n = Convert.ToInt32(readmsg);
           //ExampleMethod(n);
           
            string num1 = Console.ReadLine();
            int n1 = Convert.ToInt32(num1);
            string num2 = Console.ReadLine();
            int n2 = Convert.ToInt32(num2);
        
           
            Add(n1,n2);
        }

        static void Add(int a, int b)
        {
            // 아래와 같은 문자열을 화면에 출력한다.
            //"a + b :{0}"
            Console.WriteLine("a + b :{0} " , (a + b));
            //ExampleMethod를 (a + b 결과를 인자로) 호출하자
            int resultAdd =a + b;
            asdclass.ExampleMethod(resultAdd);
        }

    }
}
