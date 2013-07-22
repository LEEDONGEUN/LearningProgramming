using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodTest
{
    class ExampleClass
    {
        static void Main()
        {
            /*string msgRead = Console.ReadLine();
            int n = Convert.ToInt32(msgRead);*/
            string numberRead1 = Console.ReadLine();
            int n1 = Convert.ToInt32(numberRead1);
            string numberRead2 = Console.ReadLine();
            int n2 = Convert.ToInt32(numberRead2);
            //ExampleMethod(n);
            Add(n1, n2);

        }

        static void Add(int a, int b)
        {
            Console.WriteLine("a + b : {0}",a+b.ToString());

            int resultAdd = a + b;
            AnotherClass.ExampleMethod(resultAdd);
        }

        public class AnotherClass
        {
            public static void ExampleMethod(int number)
            {
                Console.WriteLine("Number + 100: {0}" + (number + 100).ToString());
            }
        }
    }
}
