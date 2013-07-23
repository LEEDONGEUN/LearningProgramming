using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex06_method
{
    //public class AnotherClass
    //{
    //    public static void ExampleMethod1(int number)
    //    {
            //string message = Console.ReadLine();
            //Console.WriteLine("{0} + 100 = {1}", number, (number + 100).ToString());
            //if (number > 0)
            //{
            //    ExampleMethod1(--number);
            //}
        }
    }
    //class ExampleMethod
    //{
    //    public static void ExampleMethod1(string message)
    //    {
    //        Console.WriteLine("Example Method");
    //    }
    //}
    class Program
    {
        //static void ExampleMethod1(string message)
        //{
        //    Console.WriteLine(message);
        //}
        //static void ExampleMethod1(string message)
        //{
        //    Console.WriteLine("Example Method");
        //}
        static void ExampleMethod1(int number)
        {
            //string message = Console.ReadLine();
            Console.WriteLine("{0} + 100 = {1}", number, (number + 100).ToString());
            //if (number > 0)
            //{
            //    ExampleMethod1(--number);
            //}
        }

        static void Add(int a, int b)
        {
            //string c = (a + b).ToString();
            //int c = a + b;
            //Console.WriteLine("{0} + {1} = {2}", a, b, resultAdd);
            //examplemethod를 (a+b결과를 인자로) 호출하자
            int resultAdd = a + b;
            return;
            Console.WriteLine("{0} + {1} = {2}", a, b, resultAdd);
            ExampleMethod1(resultAdd);
        }
        static void Main(string[] args)
        {
            //int readnumber = int.Parse(Console.ReadLine());
            //ExampleMethod1(readnumber);
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            Add(number1, number2);
            Console.WriteLine("End");
        }
    }
}