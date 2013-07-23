using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MehodsTest
{
/*    class ExampleClass
    {
        static void ExamleMethod(string msg)
        {
            Console.WriteLine(msg);
        }
        static void Main(string[] args)
        {
            //WxampleClass.ExamleMethod();
            //string msg = "Example method";
            string msgRead = Console.ReadLine();
            ExamleMethod(msgRead);
            //ExamleMethod("Example method");


        }
    }*/
 /*   class ExampleClass1
    {
        static void ExamleMethod(int number)
        {
            //Console.WriteLine("Number + 100: " + (number + 100).ToString());
            Console.WriteLine("Number + 100: {0}" ,(number + 100));
        }
        static void Main(string[] args)
        {
            string msgRead = Console.ReadLine();
            int INTmsgRead = int.Parse(msgRead);
            //int INTmsgRead = Convert.ToInt32(msgRead);
            ExamleMethod(INTmsgRead);
        }
    }*/
/*
    class ExampleClass2
    {
        static void add(int a, int b)
        {
            //"a + b: {0}"
            Console.WriteLine("a + b : {0}" , (a+b));
        }
        static void Main(string[] args)
        {
            //화면에서 두 개의 숫자를 읽는다.
            //add 메서드를 호출한다.
//           int a = 45;
//           int b = 55;
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            int INTa = int.Parse(a);
            int INTb = int.Parse(b);
            add(INTa, INTb);
        } */
    /*
    class ExampleClass3
    {
        static void add(int a, int b)
        {
            //"a + b: {0}"
            Console.WriteLine("a + b : {0}" , (a+b));
            int number = a + b;
            ExampleMethod(number);
        }
        static void ExampleMethod(int number)
        {
            Console.WriteLine("Number + 100: {0}", (number + 100));

        }
        static void Main(string[] args)
        {
            //화면에서 두 개의 숫자를 읽는다.
            //add 메서드를 호출한다.
//           int a = 45;
//           int b = 55;
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            int INTa = int.Parse(a);
            int INTb = int.Parse(b);
            add(INTa, INTb);
        } */


    class ExampleClass4
    {
        static void add(int a, int b)
        {
            //"a + b: {0}"
            Console.WriteLine("a + b : {0}" , (a+b));
            int number = a + b;
            AnotherClass.ExampleMethod(number);
        }

             static void Main(string[] args)
        {
            //화면에서 두 개의 숫자를 읽는다.
            //add 메서드를 호출한다.
//           int a = 45;
//           int b = 55;
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            int INTa = int.Parse(a);
            int INTb = int.Parse(b);
            add(INTa, INTb);
        }

        class AnotherClass
        {
            public static void ExampleMethod(int number)
            {
                  Console.WriteLine("Number + 100: {0}", (number + 100));
            }
        }
        
    }
}
